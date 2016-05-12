using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using DG.Tweening;

public class Enemy : MonoBehaviour, IDestroyable
{

    public float speed;
    public float health;
    public float size;
    public float damage;
    public float explosionDamage;
    public float explosionForcePerSize;
    public GameObject dangerZone;

    public List<GameObject> targets = new List<GameObject>();
    public GameObject target;
    float rotationSpeed;
    public float rotationSpeedMax;

    void Awake()
    {
        EnemyManager.Instance.enemies.Add(gameObject);
    }

    // Use this for initialization
    void Start()
    {
        rotationSpeed = Random.Range(-rotationSpeedMax, rotationSpeedMax);
        foreach(GameObject obj in GameObject.FindGameObjectsWithTag("Player"))
        {
            targets.Add(obj);
        }
    }

    void OnDrawGizmosSelected()
    {
        // Display the explosion radius when selected
        Gizmos.color = Color.white;
        Gizmos.DrawSphere(transform.position, transform.localScale.magnitude);
    }

    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, GetClosest().transform.position, speed * Time.deltaTime);
        transform.Rotate(Vector3.up * Time.deltaTime * rotationSpeed);

    }

    GameObject GetClosest()
    {
        GameObject ret = null;
        float dist = Mathf.Infinity;
        foreach (GameObject obj in targets)
        {
            if (obj == null)
                continue;
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
                EnemyManager.Instance.enemies.Remove(col.transform.gameObject);
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
            GetComponent<SphereCollider>().enabled = false;
            Destroy(GetComponent<Rigidbody>());
            Invoke("Death", 1f);
            transform.DOShakePosition(1f, 0.5f,50,80f,false);
            transform.DOShakeRotation(1f, 0.1f,5,80f);
            dangerZone.SetActive(true);
            Score.Inst.AddPoint((int)size);

        }
    }

    public void Death()
    {
        Explode();
        EnemyManager.Instance.enemies.Remove(gameObject);
        Destroy(gameObject);
    }

    public void ResetEnemyList(GameObject doNotTake)
    {
        targets.Remove(doNotTake);
        GetClosest();
    }

    void Explode()
    {
        ScreenShakeManager.Inst.Shake(( size / 4f));

        Collider[] hits = Physics.OverlapSphere(transform.position, transform.localScale.magnitude);
        
        foreach (Collider hit in hits)
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
