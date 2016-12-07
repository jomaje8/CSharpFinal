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
            break;

            case "Werewolf":

            break;

            case "Yeti"

            break;

            case "Imp":
            break;

            case "Human":

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