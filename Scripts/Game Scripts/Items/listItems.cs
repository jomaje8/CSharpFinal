using System.Collections.Generic;
using System;

public class listItems
{
    public List<Items> listOfItems;
    public Game start = new Game();

    public void RunList()
    {
        listOfItems = new List<Items>();
        ChangeList("Guns", "Roses");
        if (listOfItems.Count == 2)
        {
            start.Play();
        }
    }

    public void ChangeList(string name, string power)
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
