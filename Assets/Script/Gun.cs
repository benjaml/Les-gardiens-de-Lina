using UnityEngine;
using System.Collections;

public class Gun : AbstractWeapon {

    
    public override void Init()
    {
        type = EnumerationGun.GunType.GUN;
        damage = 1.0f;
        fireRate = 0.1f;
        dispersion = 0.2f;
        sound = Resources.Load<AudioClip>("Sound/Gun2");
        bullet = Resources.Load<GameObject>("Prefab/Bullet/GunBullet"+GetComponent<Player>().playerId);

        base.Init(); 
    }
    

    public override void GiveTo(Player player)
    {
        if (player.currentWeapon.type == EnumerationGun.GunType.GUN)
            return;
        Destroy(player.currentWeapon);
        AbstractWeapon nextGun = player.gameObject.AddComponent<Gun>();
        AttachTo(player.gameObject,typeof(Gun));
        if (gameObject.tag != "Player")
            Destroy(gameObject);
    }

}
