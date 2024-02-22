using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Riffle : Weapon
{
    public Riffle()
        {
            Type = Weapontype.Shotgun;
        }

        public override WeaponStats GetStats()
        {
            return new WeaponStats{damage = 45 , fireRate = 2.5f , ammo = 30};
        }

        public override void Fire()
        {
            Debug.Log("Riffle Firing");
        }

        public override void Reload()
        {
            Debug.Log("Riffle Reloading");
        }
    

}
