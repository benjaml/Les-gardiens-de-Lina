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
    public Light fireLight;

    public ParticleSystem particleGenerator;

    public int bulletFired;

    public Text text;

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
        fireLight = fireStart.GetComponent<Light>();
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
        shootStart = Time.time;
        particleGenerator.Emit(1);
        bulletFired++;
        text.text = "BULLET FIRED " + bulletFired.ToString();
        Vector3 direction = fireStart.transform.position - transform.position;
        direction.y = 0f;
        direction.Normalize();
        currentWeapon.Shoot(playerId, fireStart.transform.position, direction);
        fireLight.enabled = true;
        Invoke("StopLight", 0.1f);

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
        Destroy(gameObject);
    }

    void ResetInvincibility()
    {
        invincible = false;
    }
    
    void StopLight()
    {
        fireLight.enabled = false;
    }

    void Health()
    {
        life.fillAmount = 0f + ((100f / maxHealthPoint * healthPoint) / 100f);
    }
    
}
