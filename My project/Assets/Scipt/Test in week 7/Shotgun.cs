using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shotgun : Weapon
{
    public Shotgun()
    {
        Type = Weapontype.Shotgun;
    }

    public override WeaponStats GetStats()
    {
        return new WeaponStats{damage = 100 , fireRate = 1.5f , ammo = 6};
    }

    public override void Fire()
    {
        Debug.Log("Shotgun Firing");
    }

    public override void Reload()
    {
        Debug.Log("Shotgun Reloading");
    }

}
