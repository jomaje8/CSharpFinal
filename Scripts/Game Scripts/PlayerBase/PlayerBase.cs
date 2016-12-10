using System;
public class PlayerBase{
    public string playerType;
    public string playerName;
    public static int armor;

     public void typeSelection(){
    Console.WriteLine("What type of creature are you?");
    Console.WriteLine("Centaur, Werewolf, Yeti, Imp, Human");
    playerType = Console.ReadLine();
    
     switch(playerType) {
         case "Centaur":
         Console.WriteLine("Nice Pants");
         Console.WriteLine("Health: " + (armor + 60));
         break;

         case "Werewolf":
         Console.WriteLine("Wow, what nice teeth you have");
         Console.WriteLine("Health: " + (armor + 90));
         break;

         case "Yeti":
         Console.WriteLine("Snowcone?");
         Console.WriteLine("Health: " + (armor + 100));
         break;

         case "Imp":
         Console.WriteLine("Ah, you little devil");
         Console.WriteLine("Health: " + (armor + 5));
         break;

         case "Human":
         Console.WriteLine("Oh, um, Good Luck?");
         Console.WriteLine("Health " + (armor + 10));
         break;

         default:
         Console.WriteLine("this is not a valid Race!");
         typeSelection();
         break;

     }
    }

            public void NameFunction (){
            Console.WriteLine("What is your name?");
            name = Console.ReadLine();
            if (name == String.Empty)
            {
                Console.WriteLine("Um, You said nothing, try again.");
            } else {
                Console.WriteLine("Welcome " + name + " prepare for your journey.");
            }
        }
   
    public string name;



}