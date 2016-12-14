using System.Collections.Generic;
using System;
public class WeaponBase {
    public List<Weapon> listOfWeapons;
    public WeaponBase () {
        listOfWeapons = new List<Weapon>();
        ChangeList("Sword", 10);
        ChangeList("Glock", 20);
        ChangeList("Smile", 40);
        GetListOfWeapons();
    }
    private void ChangeList (string name, int power) {
        Weapon newWeapon = new Weapon();
        newWeapon.name = name;
        newWeapon.power = power;
        listOfWeapons.Add(newWeapon);
    }
    public void GetListOfWeapons () {
        Console.WriteLine(listOfWeapons.Count);
        foreach(Weapon weapon in listOfWeapons) {
            Console.WriteLine(weapon.name + " is the name of your weapon.");
            Console.WriteLine(weapon.power + " is the power of your weapon.");
        }
    }
}