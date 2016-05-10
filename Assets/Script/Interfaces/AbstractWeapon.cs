using UnityEngine;
using System.Collections;
using System;

public abstract class AbstractWeapon : AbstractPickable {

    public EnumerationGun.GunType type;
    public float damage;
    public float fireRate;
    public AudioClip sound;
    public GameObject bullet;



    public override void Init()
    {
        base.Init();
    }
    

    public void Shoot(int ShooterID,Vector3 startPos,Vector3 direction)
    {
        Instantiate(bullet, startPos, Quaternion.LookRotation(direction));
        GetComponent<AudioSource>().PlayOneShot(sound);
    }

    public void SetPicked(bool value)
    {
        Picked = value;
    }
    
    public void AttachTo(GameObject obj,System.Type type)
    {
        obj.GetComponent<AudioSource>().Stop();
        Player player = obj.GetComponent<Player>();
        player.currentWeapon = (AbstractWeapon)obj.GetComponent(type);
        player.currentWeapon.SetPicked(true);

    }



}
