using UnityEngine;
using System.Collections;
using System;

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
    }

    public void ChangeGun(EnumerationGun.GunType typeOfGun)
    {
        GetComponent<AudioSource>().Stop();
        if (currentWeapon.type == typeOfGun)
            return;
        System.Type type = null;
        switch(typeOfGun)
        {
            case EnumerationGun.GunType.GUN:
                type = typeof(Gun);
                break;
            case EnumerationGun.GunType.LASERGUN:
                break;
            case EnumerationGun.GunType.MINIGUN:
                break;
            case EnumerationGun.GunType.SHOTGUN:
                break;
            case EnumerationGun.GunType.SNIPER:
                break;
        }
        ChangeGun(type);


    }

    public void ChangeGun(System.Type type)
    {
        Destroy(currentWeapon);
        AbstractWeapon nextGun = (AbstractWeapon)gameObject.AddComponent(type);
        nextGun.AttachTo(gameObject,type);

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
        Vector3 direction = fireStart.transform.position - transform.position;
        direction.y = 0f;
        direction.Normalize();
        currentWeapon.Shoot(playerId, fireStart.transform.position, direction);
        Invoke("StopLight", 0.05f);
        muzzle.SetActive(true);

    }

    void Repel()
    {
        repelStart = Time.time;
        Vector3 direction = fireStart.transform.position - transform.position;
        direction.y = 0f;
        direction.Normalize();
        Collider[] hits = Physics.OverlapSphere(transform.position + direction * repelRadius, repelRadius);
        foreach(Collider hit in hits)
        {
            if(hit.transform.gameObject != gameObject)
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
    
}
