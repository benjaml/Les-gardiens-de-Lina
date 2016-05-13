using UnityEngine;
using System.Collections;

public abstract class AbstractWeapon : AbstractPickable {

    public EnumerationGun.GunType type;
    public float damage;
    public float dispersion;
    public float fireRate;
    public AudioClip sound;
    public GameObject bullet;



    public override void Init()
    {
        base.Init();
    }
    

    public void Shoot(int ShooterID,Vector3 startPos,Vector3 direction)
    {
        Vector3 posToLook = transform.position + direction;
        posToLook.x += Random.Range(-1f, 1f) * dispersion;
        posToLook.z += Random.Range(-1f, 1f) * dispersion;
        direction = (posToLook - transform.position).normalized;
        Instantiate(bullet, startPos, Quaternion.LookRotation(direction));
        GetComponent<AudioSource>().pitch = 1 + Random.Range(-0.1f, 0.4f);
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
