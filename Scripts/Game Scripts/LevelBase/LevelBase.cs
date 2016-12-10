using System;

public class LevelBase
{
    public bool entranceOpen = true;
    public static Game start = new Game();
    public static Drop Nuts = new Drop();
    public int nuts = 2;
    public static WeaponBase lists = new WeaponBase();

    public string[] Enemies = { " Lion", " Sphynx", " Butterfly", " Drunk man named Bob" };

    public void itemDrop()
    {
        Console.WriteLine("This Beast dropped: ");
        string[] items = new string[3];
        items[0] = "Guns";
        items[1] = "Roses";
        items[2] = "A Sack of Nuts";

        foreach (string item in items)
        {
            Console.WriteLine(item);
        }
    }
    public void nutCount()
    {
        for (int i = 0; i < nuts; i++)
        {
            Console.WriteLine("Nuts collected: " + i);
        }
    }
    public void enter()
    {
        Console.WriteLine("Welcome to Asuom! Land known for its plentiful Palm Nuts");
        Console.WriteLine("Your Story begins at the enterence of a forest.");
    }

    public void Spot(int i)
    {
        switch (i)
        {
            case 0:
                Console.WriteLine("You have been attacked by a" + Enemies[i]);
                GameStatusBase.AttackFunction();
                itemDrop();
                nutCount();
                Console.WriteLine("Total Nuts: ");
                Nuts.nutCount();
                Console.WriteLine("Ooo loot! Take some please: ");
                lists.RunList();
                start.Play();
                break;

            case 1:
                Console.WriteLine("You have been attacked by a" + Enemies[i]);
                GameStatusBase.AttackFunction();
                itemDrop();
                nutCount();
                Console.WriteLine("Total Nuts: ");
                Nuts.nutCount();
                Console.WriteLine("Ooo loot! Take some please: ");
                lists.RunList();
                start.Play();
                break;

            case 2:
                Console.WriteLine("You have been attacked by a" + Enemies[i]);
                GameStatusBase.AttackFunction();
                itemDrop();
                nutCount();
                Console.WriteLine("Total Nuts: ");
                Nuts.nutCount();
                Console.WriteLine("Ooo loot! Take some please: ");
                lists.RunList();
                start.Play();
                break;

            case 3:
                Console.WriteLine("You have been attacked by a" + Enemies[i]);
                if (Enemies[i] == "Butterfly")
                {
                }
                Game.canPlay = false;
                break;

            default:
                Console.WriteLine("You have encountered no enemy.");
                start.Play();
                break;

        }

    }

}