using System;
using System.Collections.Generic;


public class MagicBase
{
    public static GameStatusBase list = new GameStatusBase();
    public static List<string> list1 = new List<string>() {};
    public string name;
    public static int Power = 10;
    public static int Strength = 10;
    public static string magicName;
    public static void Magic()
    {
        Console.WriteLine("Magical Abilities: ");
        string[] Magic = new string[3];
        Magic[0] = "Freeze";
        Magic[1] = "Melt";
        Magic[2] = "Dust Cloud";

        foreach (string item in Magic)
        {
            Console.WriteLine(item);
        }
    }
    public static void pickPower()
    {
        Console.WriteLine("What power do you have?");
        Console.WriteLine("Mind Control, Lazer Vision, Super Speed");
        magicName = Console.ReadLine();
        switch (magicName)
        {
            case "Mind Control":
                Console.WriteLine("You can't tell me what to do!");
                Magic();
                Console.WriteLine("Power: " + (Power + 50));
                Console.WriteLine("Strength: " + (Strength + 5));
                break;

            case "Lazer Vision":
                Console.WriteLine("Does that hurt your eyes?");
                Magic();
                Console.WriteLine("Power: " + (Power + 20));
                Console.WriteLine("Strength: " + (Strength + 20));
                break;

            case "Super Speed":
                Console.WriteLine("So you think your fast?");
                Magic();
                Console.WriteLine("Power: " + (Power + 10));
                Console.WriteLine("Strength: " + (Strength + 10));
                break;

            default:
                Console.WriteLine("Not Magical? Bummer");
                Console.WriteLine("Power: " + (Power + 0));
                Console.WriteLine("Strength: " + (Strength + 0));
                break;
        }
    }

}