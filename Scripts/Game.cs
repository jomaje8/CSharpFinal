using System;
public class Game {
    public static Action StartGame;
    public static bool canPlay = true;
    public Game () 
    {
        mountainLevel.StartMessage = "You have arrived at the base of a mountain";
        mountainLevel.objects();
    }

public void Start (){

Console.WriteLine("Plaease enter your name");
PlayerBase.playerName = Console.ReadLine();
Console.WriteLine("Welcome " + PlayerBase.playerName + ".")
}

}