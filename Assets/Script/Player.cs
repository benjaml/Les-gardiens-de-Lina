using UnityEngine;
using System.Collections;
using System;
using UnityEngine.UI;


public class Player : MonoBehaviour, IDestroyable{

    [Header("Weapon")]
    public AbstractWeapon currentWeapon;
    public GameObject fireStart;

    [Header("Stats")]
    public int playerId;
    public float healthPoint;
    public float maxHealthPoint;

    public float repelRadius;
    public float repelDelay;
    public float repelForce;

    public ParticleSystem particleGenerator;
    public GameObject muzzle;
    public GameObject shockwave;


    public int bulletFired;
    

    public Image life;


    bool invincible = false;
    bool shooting = false;
    bool repel = false;
    float shootStart;
    float repelStart;

    void Awake()
    {
        Gun gun = gameObject.AddComponent<Gun>();
        gun.AttachTo(gameObject,typeof(Gun));
        healthPoint = maxHealthPoint;
    }

    // Update is called once per frame
	void Update () {

        if (XInput.instance.getTriggerRight(playerId)>0.5f && !shooting && Time.time > shootStart + currentWeapon.fireRate)
        {
            InvokeRepeating("Shoot",0f,currentWeapon.fireRate);
            shooting = true;
        }
        if (XInput.instance.getTriggerRight(playerId) < 0.5f && shooting)
        {
            CancelInvoke("Shoot");
            shooting = false;
        }

        if (XInput.instance.getTriggerLeft(playerId) > 0.5f && !repel && Time.time>repelStart+repelDelay)
        {
            InvokeRepeating("Repel", 0f, repelDelay);
            repel = true;
        }
        if (XInput.instance.getTriggerLeft(playerId) < 0.5f && repel)
        {
            CancelInvoke("Repel");
            repel = false;
        }
        
        Health();
    }
    
    

    public void applyDamage(float damage, int killerID = -1)
    {
        healthPoint -= damage;
        if (healthPoint <= 0)
            Death();
    }

    void Shoot()
    {
        XInput.instance.useVibe(playerId-1, currentWeapon.fireRate, 0.12f, 0.12f);
        shootStart = Time.time;
        particleGenerator.Emit(1);
        bulletFired++;
        Vector3 direction = fireStart.transform.position - transform.position;
        direction.y = 0f;
        direction.Normalize();
        currentWeapon.Shoot(playerId, fireStart.transform.position, direction);
        Invoke("StopLight", 0.05f);
        muzzle.SetActive(true);

    }

    void Repel()
    {
        Vector3 direction = fireStart.transform.position - transform.position;
        direction.y = 0f;
        direction.Normalize();
        GameObject instance = Instantiate(shockwave, fireStart.transform.position, Quaternion.LookRotation(direction)) as GameObject;
        Destroy(instance, 1f);
        repelStart = Time.time;
        direction = fireStart.transform.position - transform.position;
        direction.y = 0f;
        direction.Normalize();
        Collider[] hits = Physics.OverlapSphere(transform.position + direction * repelRadius, repelRadius);
        foreach(Collider hit in hits)
        {
            if(hit.transform.gameObject != gameObject && hit.transform.tag != "Player")
            {
                // add force on forward direction
                if(hit.transform.GetComponent<Rigidbody>())
                {
                    Vector3 force = hit.transform.position - transform.position;
                    force.Normalize();
                    force *= repelForce;
                    hit.transform.GetComponent<Rigidbody>().AddForce(force);
                }
            }
        }

    }

    public void Death()
    {
        foreach(GameObject obj in GameObject.FindGameObjectsWithTag("Enemy"))
        {
            obj.GetComponent<Enemy>().ResetEnemyList(gameObject);
        }
        Destroy(gameObject);
    }

    void ResetInvincibility()
    {
        invincible = false;
    }
    
    void StopLight()
    {
        muzzle.SetActive(false);
    }

    void Health()
    {
        life.fillAmount = 0f + ((100f / maxHealthPoint * healthPoint) / 100f);
    }
    
}
