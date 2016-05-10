using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour, IDestroyable{

    [Header("Weapon")]
    public AbstractWeapon currentWeapon;
    public GameObject fireStart;

    [Header("Stats")]
    public int playerId;
    public float healthPoint;
    public float maxHealthPoint;



    Animator anim;
    bool invincible = false;
    bool shooting = false;

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
            CancelInvoke();
            shooting = false;
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

    }

    void Shoot()
    {
        currentWeapon.Shoot(playerId, fireStart.transform.position, transform.forward);
    }

    public void Death()
    {
        // do nothing yet
    }

    void ResetInvincibility()
    {
        invincible = false;
    }
}
