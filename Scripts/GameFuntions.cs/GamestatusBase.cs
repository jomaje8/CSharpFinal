using System;
using System.Collections.Generic;
public class GameStatusBase{

    public static Drop Health = new Drop();
    public static Items lists = new Items();
    public static string AttackLine;
    public static int OfHits = 3;
    public static void AttackFunction()

    {
        Console.WriteLine("You Spot a threatening beast!");
        Console.WriteLine("Will you Attack or Run?");
        AttackLine = Console.ReadLine();
        if (AttackLine == "Attack")
        {
            Console.WriteLine("You have attacked the Enemy!");
            while (OfHits > 0)
            {
                Console.WriteLine("You hit the beast!");
                OfHits--;
            }
            Console.WriteLine("You managed to kill the beast! but lost a little health!");
            Console.WriteLine("Health: ");
            Health.Healthy();
            
        }
        else if (AttackLine == "Run")
        {
            Console.WriteLine("Run!! What a stupid choice!");
            Console.WriteLine("The beast attacks from behind and you take a fatal hit!");
            Console.WriteLine("You Died!");
            Console.WriteLine("Game Over");
            Environment.Exit(0);
        }
    }
      public enum GameStates {Start, End, Fight, Play, Continue, Run, Died, Help}

    public static GameStates currentGamestatus = GameStates.Start;  
}
  
