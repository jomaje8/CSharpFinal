using System.Collections.Generic;
using System;

public class listItems
{
    public List<Items> listofWeapons;
    public Game start = new Game();

    public void RunList()
    {
        listofWeapons = new List<Items>();
        ChangeList("Guns", "Roses");
        if (listofWeapons.Count == 2)
        {
            start.Play();
        }
    }

    public void ChangeList(string name, string power)
    {
        Items newWeapon = new Items();
        newWeapon.name = name;
        newWeapon.power = power;
        listofWeapons.Add(newWeapon);

        Items newWeapons = new Items();
        newWeapon.name = Console.ReadLine();
        newWeapon.power = Console.ReadLine();


        listofWeapons.Add(newWeapons);

        ChangeList("Guns", "Roses");


    }
}
