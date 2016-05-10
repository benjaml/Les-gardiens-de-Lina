using UnityEngine;
using System.Collections;
using System;

public class Enemy : MonoBehaviour,IDestroyable {

    public float speed;
    public float health;
    public float size;
    public float damage;
    public float explosionDamage;

    NavMeshAgent agent;
    public GameObject[] targets;
    public GameObject target;

    // Use this for initialization
    void Start () {
        agent = GetComponent<NavMeshAgent>();
        targets = GameObject.FindGameObjectsWithTag("Player");
        target = GetClosest();
        InvokeRepeating("GetClosest", 0f, 1f);
	}

    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position,target.transform.position,speed*Time.deltaTime);
    }

    GameObject GetClosest()
    {
        GameObject ret = null;
        float dist = Mathf.Infinity;
        foreach(GameObject obj in targets)
        {
            float tmp = Vector3.Distance(transform.position, obj.transform.position);
            if(tmp < dist)
            {
                dist = tmp;
                ret = obj;
            }
        }
        return ret;
    }

    void OnTriggerEnter(Collider col)
    {
        Debug.Log(col.transform.tag);
        if(col.transform.tag == "Enemy")
        {
            Enemy other = col.transform.GetComponent<Enemy>();
            if(other == null)
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
    }

    void Fusion(Enemy enemy)
    {
        size += enemy.size;
        transform.localScale = Vector3.one * size;
        damage += enemy.damage;
        explosionDamage += enemy.explosionDamage;
        Destroy(enemy.gameObject);
    }

    public void applyDamage(float damage, int killerID = -1)
    {
        health -= damage;
        if (health < 0f)
            Death();
    }

    public void Death()
    {
        Destroy(gameObject);
    }
}
