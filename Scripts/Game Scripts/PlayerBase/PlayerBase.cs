using System;
public class PlayerBase{
    public string playerType;
    public string playerName;

    public void typeSelection(){
        Console.WriteLine("What type of creature are you?");
        Console.WriteLine("Dragon, Werewolf, Yeti, Imp, Human");
        playerType = Console.ReadLine();

        public int health;
        public int armor; 
        public int power;

        switch(playerType) {
            case "Dragon":
            Console.WriteLine("Well hello mighty creature!");
            PlayerBase.health = 100;
            PlayerBase.armor = 200;
            PlayerBase.power = 100;
            public string Magic.name = "fire";
            break;

            case "Werewolf":
            Console.WriteLine("Oh my, Look at those teeth!");
            PlayerBase.health = 100;
            PlayerBase.armor = 75;
            PlayerBase.power = 100;
            public string Magic.name = "Bite";

            break;

            case "Yeti":
            Console.WriteLine("So you do exist!");
            PlayerBase.health = 100;
            PlayerBase.armor = 75;
            PlayerBase.power = 100;
            public string Magic.name = "Freeze";

            break;

            case "Imp":
            Console.WriteLine("Why you little devil, Welcome!"):
            PlayerBase.health = 100;
            PlayerBase.armor = 25;
            PlayerBase.power = 50;
            public string Magic.name = "Multiply";
            break;

            case "Human":
            Console.WriteLine("A human? HaHa, Good Luck!");
            PlayerBase.health = 100;
            PlayerBase.armor = 15;
            PlayerBase.power = 25;
            break;
            
            default:
            Console.WriteLine("This is not an acceptable race!!");
            break;
        }
    }

    public PlayerBase()
    {

    }


}