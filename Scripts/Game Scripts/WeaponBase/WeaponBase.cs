using System.Collections.Generic;
using System;
public class WeaponBase {
       //List
    public static List<Weapon> listOfWeapons;

    public void RunList () {
        
        listOfWeapons = new List<Weapon>();

    }

    public static void ChangeList (string name , int power) {
        Console.WriteLine(listOfWeapons.Count);

        foreach(Weapon weapon in listOfWeapons) {
            Console.WriteLine(weapon.name + " is the name of your weapon.");
            Console.WriteLine(weapon.power + " is the power of your weapon.");
        }

        Weapon newWeapon = new Weapon();
        newWeapon.name = Console.ReadLine();
        newWeapon.power = int.Parse(Console.ReadLine());

        listOfWeapons.Add(newWeapon);

        ChangeList("sword", 20);
    }
}