using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pistol : Weapon
{
    public Pistol()
    {
        Type = Weapontype.Pistol;
    }

    public override WeaponStats GetStats()
    {
        return new WeaponStats{damage = 20 , fireRate = 0.5f , ammo = 10};
    }

    public override void Fire()
    {
        Debug.Log("Pistol Firing");
    }

    public override void Reload()
    {
        Debug.Log("Pistol Reloading");
    }
}
