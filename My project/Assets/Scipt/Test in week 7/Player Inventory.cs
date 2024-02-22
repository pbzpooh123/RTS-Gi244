using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInventory : MonoBehaviour
{
    public List<Weapon> weapons = new List<Weapon>();

    public Weapon[] EquippedWeapon = new Weapon[2];

    public void AddWeapon(Weapontype type)
    {
        weapons.Add(Weapon.CreateWeapon(type));
            
    }
}
