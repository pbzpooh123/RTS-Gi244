using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum Weapontype
{
    Pistol,
    Rifle,
    Shotgun
}

public struct WeaponStats
{
    public int damage;
    public float fireRate;
    public int ammo;
}

public abstract class Weapon : MonoBehaviour
{
    private Weapontype type;
    public Weapontype Type
    {
        get { return type; }
        set { type = value; }
    }


    void Start()
    {
        
    }

    void Update()
    {
        
    }

    public abstract WeaponStats GetStats();
    public abstract void Fire();
    public abstract void Reload();

    public static Weapon CreateWeapon(Weapontype type)
    {
        Weapon weapon = null;
        switch (type)
        {
            case Weapontype.Pistol:
                weapon = new Pistol();
                break;

            case Weapontype.Rifle:
                weapon = new Riffle();
                break;
            case Weapontype.Shotgun:
                weapon = new Shotgun();
                break;
            default:
                Debug.Log("Invalid Wrong Weapon Type");
                break;

        }

        return weapon;
    }

}