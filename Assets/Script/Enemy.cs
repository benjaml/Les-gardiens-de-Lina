﻿using UnityEngine;
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
    public GameObject explosion;
    bool killedByPlayer = false;
    bool knockup = false;
    float knockupLength = 0.2f;
    float knockupStart = 0f;

    public AudioClip explosionSound;

    void Awake()
    {
        EnemyManager.Instance.enemies.Add(gameObject);
        EnemyManager.Instance.totalCount++;
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
    public void Knockup()
    {
        knockupStart = Time.time;
        knockup = true;
    }
    void Update()
    {
        if (knockup)
        {
            if (Time.time < knockupStart + knockupLength)
            {
                return;
            }
            else
            {
                knockup = false;        
            }
         }

        GameObject cible = GetClosest();
        if (cible == null)
            return;
        transform.position = Vector3.MoveTowards(transform.position, cible.transform.position, speed * Time.deltaTime);
        transform.Rotate(Vector3.up * Time.deltaTime * rotationSpeed);

    }

    GameObject GetClosest()
    {
        GameObject ret = null;
        float dist = Mathf.Infinity;
        foreach (GameObject obj in GameObject.FindGameObjectsWithTag("Player"))
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
            if (size >= other.size && size < 4f)
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
        health += 2f;
        size += 1f;
        transform.localScale = Vector3.one * (size);
        speed -= 0.3f;
        damage += 1f;
        explosionDamage += 1f;
        Destroy(enemy.gameObject);
    }

    public void applyDamage(float damage, int killerID = -1)
    {
        health -= damage;
        transform.DOPunchScale(Vector3.one * -0.1f*size, 0.1f, 5, 0.1f);
        if (health <= 0f)
        {
            speed = 0f;
            GetComponent<SphereCollider>().enabled = false;
            Destroy(GetComponent<Rigidbody>());
            Invoke("Death", 0.2f);
            if(killerID!=-1)
            {
                killedByPlayer = true;
                PlayerManager.instance.enemyKilled++;
            }
            transform.DOShakePosition(1f, 0.5f,50,80f,false);
            transform.DOShakeRotation(1f, 0.1f,5,80f);
            dangerZone.SetActive(true);

        }
    }

    public void Death()
    {
        Explode();
        if(killedByPlayer)
            Score.Inst.AddPoint((int)size);
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
        GameObject source = new GameObject();
        AudioSource audio = source.AddComponent<AudioSource>();
        audio.pitch += Random.Range(-0.1f, 0.4f);
        audio.clip = explosionSound;
        audio.loop = false;
        audio.Play();
        Destroy(source, 1f);

        ScreenShakeManager.Inst.Shake(( size / 4f));
        GameObject instance = Instantiate(explosion, transform.position, explosion.transform.rotation) as GameObject;
        instance.transform.localScale *= transform.localScale.magnitude;
        instance.transform.GetChild(0).GetChild(0).localScale *= transform.localScale.magnitude;
        Destroy(instance, 1.1f);
        
        Collider[] hits = Physics.OverlapSphere(transform.position, transform.localScale.magnitude);
        
        foreach (Collider hit in hits)
        {
            if (hit.transform.gameObject != gameObject)
            {
                if (hit.transform.GetComponent(typeof(IDestroyable)))
                {
                    IDestroyable target = hit.transform.GetComponent(typeof(IDestroyable)) as IDestroyable;

                    if (killedByPlayer)
                        target.applyDamage(damage, 1);
                    else
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
