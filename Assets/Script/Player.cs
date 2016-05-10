﻿using UnityEngine;
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



    Animator anim;
    bool invincible = false;
    bool shooting = false;
    bool repel = false;

    void Awake()
    {
        Gun gun = gameObject.AddComponent<Gun>();
        gun.AttachTo(gameObject,typeof(Gun));
        healthPoint = maxHealthPoint;
        anim = GetComponentInChildren<Animator>();
    }

    
	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {

        if (Input.GetAxisRaw("Fire1")>0.5f && !shooting)
        {
            InvokeRepeating("Shoot",0f,currentWeapon.fireRate);
            shooting = true;
        }
        if (Input.GetAxisRaw("Fire1") < 0.5f && shooting)
        {
            CancelInvoke("Shoot");
            shooting = false;
        }

        if (Input.GetAxisRaw("Fire2") > 0.5f && !repel)
        {
            InvokeRepeating("Repel", 0f, repelDelay);
            repel = true;
        }
        if (Input.GetAxisRaw("Fire2") < 0.5f && repel)
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
        currentWeapon.Shoot(playerId, fireStart.transform.position, transform.forward);
    }
    void Repel()
    {
        RaycastHit[] hits = Physics.SphereCastAll(transform.position + transform.forward * repelRadius, repelRadius, transform.forward);
        foreach(RaycastHit hit in hits)
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
        Debug.Log("You are dead");
        Destroy(gameObject);
    }

    void ResetInvincibility()
    {
        invincible = false;
    }
    
}
