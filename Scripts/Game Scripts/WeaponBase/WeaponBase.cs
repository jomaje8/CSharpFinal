using System.Collections.Generic;
using System;
public class WeaponBase {
       //List
    public List<Weapon> listOfWeapons;

    public void RunList () {
        
        listOfWeapons = new List<Weapon>();

        ChangeList();
    }

    private void ChangeList () {
        Console.WriteLine(listOfWeapons.Count);

        foreach(Weapon weapon in listOfWeapons) {
            Console.WriteLine(weapon.name + " is the name of your weapon.");
            Console.WriteLine(weapon.power + " is the power of your weapon.");
        }

        Weapon newWeapon = new Weapon();
        newWeapon.name = Console.ReadLine();
        newWeapon.power = int.Parse(Console.ReadLine());

        listOfWeapons.Add(newWeapon);

        ChangeList();
    }
}