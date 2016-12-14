using System.Collections.Generic;
using System;

public class listItems
{
    public static List<Items> listOfItems;
    public static Game start = new Game();

    public static void RunList()
    {
        listOfItems = new List<Items>();
        ChangeList("Guns", "Roses");
        if (listOfItems.Count == 2)
        {
            start.Play();
        }
    }

    public static void ChangeList(string name, string power)
    {
        Items newItem = new Items();
        newItem.name = name;
        newItem.power = power;
        listOfItems.Add(newItem);

        Items newItems = new Items();
        newItem.name = Console.ReadLine();
        newItem.power = Console.ReadLine();


        listOfItems.Add(newItems);

        ChangeList("Guns", "Roses");


    }
}
