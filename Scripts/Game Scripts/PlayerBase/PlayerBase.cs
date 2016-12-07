using System;
public class PlayerBase{
    public string playerType;
    public string playerName;
    public int armor;

     public void typeSelection(){
    Console.WriteLine("What type of creature are you?");
    Console.WriteLine("Centaur, Werewolf, Yeti, Imp, Human");
    playerType = Console.ReadLine();
    
     switch(playerType) {
         case "Centaur":
         Console.WriteLine("What is Resolve?");
         Console.WriteLine("Health: " + (armor + 60));
         break;

         case "Werewolf":
         Console.WriteLine("Class doesn't have a price.");
         Console.WriteLine("Health: " + (armor + 90));
         break;

         case "Yeti":
         Console.WriteLine("Shouldn't you wear a shirt?");
         Console.WriteLine("Health: " + (armor + 100));
         break;

         case "Imp":
         Console.WriteLine("Small body, Big Heart.");
         Console.WriteLine("Health: " + (armor + 5));
         break;

         case "Human":
         Console.WriteLine("");
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
                Game.StartGame();
            }
        }
   
    public string name;



}