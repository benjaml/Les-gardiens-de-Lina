using UnityEngine;
using System.Collections;

public class Enemy : MonoBehaviour, IDestroyable
{

    public float speed;
    public float health;
    public float size;
    public float damage;
    public float explosionDamage;
    public float explosionForcePerSize;

    public GameObject[] targets;
    public GameObject target;

    // Use this for initialization
    void Start()
    {
        targets = GameObject.FindGameObjectsWithTag("Player");
        target = GetClosest();
        InvokeRepeating("GetClosest", 0f, 1f);
    }

    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, target.transform.position, speed * Time.deltaTime);
    }

    GameObject GetClosest()
    {
        GameObject ret = null;
        float dist = Mathf.Infinity;
        foreach (GameObject obj in targets)
        {
            float tmp = Vector3.Distance(transform.position, obj.transform.position);
            if (tmp < dist)
            {
                dist = tmp;
                ret = obj;
            }
        }
        return ret;
    }

    void OnCollisionEnter(Collision col)
    {
        if (col.transform.tag == "Enemy")
        {
            Enemy other = col.transform.GetComponent<Enemy>();
            if (other == null)
            {
                return;
            }
            if (size >= other.size)
            {
                Fusion(other);
                size += other.size;
                damage += other.damage;
                explosionDamage += other.explosionDamage;
                Destroy(col.transform.gameObject);
            }
        }
        else if (col.transform.tag == "Player")
        {
            Death();
        }
    }

    void Fusion(Enemy enemy)
    {
        health += enemy.size;
        size += enemy.size;
        transform.localScale = Vector3.one * (1 + size / 4);
        damage += enemy.damage;
        explosionDamage += enemy.explosionDamage;
        Destroy(enemy.gameObject);
    }

    public void applyDamage(float damage, int killerID = -1)
    {
        health -= damage;
        if (health <= 0f)
        {
            speed = 0f;
            GetComponent<BoxCollider>().enabled = false;
            Destroy(GetComponent<Rigidbody>());
            Invoke("Death", 0.2f);
        }
    }

    public void Death()
    {
        Explode();
        Destroy(gameObject);
    }

    void Explode()
    {
        ScreenShakeManager.Inst.Shake(( size / 4f));

        RaycastHit[] hits = Physics.SphereCastAll(transform.position, (1 + size / 2f), Vector3.up);
        foreach (RaycastHit hit in hits)
        {
            if (hit.transform.gameObject != gameObject)
            {
                if (hit.transform.GetComponent(typeof(IDestroyable)))
                {
                    IDestroyable target = hit.transform.GetComponent(typeof(IDestroyable)) as IDestroyable;

                    target.applyDamage(damage);
                    Vector3 knockbackForce = hit.transform.position - transform.position;
                    knockbackForce.Normalize();
                    knockbackForce *= (1 + size / 4f) * explosionForcePerSize;
                    hit.transform.GetComponent<Rigidbody>().AddForce(knockbackForce);
                }
            }
        }
    }
}
