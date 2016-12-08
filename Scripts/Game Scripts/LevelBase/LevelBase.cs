using System;

public class LevelBase {
   
    public string StartMessage;
    public bool entranceOpen = true;

    public string[] environment;

    public string[] objects;

    public void Enter (){
        Console.WriteLine(StartMessage);
    }
    public void Cave (int i){
        switch (i){
            case 0:
                Console.WriteLine("While entering the cave you find " + objects[i]);
            break;
            case 1:
                Console.WriteLine("You've Come across " + objects[i]);
                if (objects[i] == "The flashlight!"){ 
                    Game.GameTimer();
                    Console.WriteLine("You've sucessfully found a flashlight! You turn it on and can now see.");
                }
            break;
       }
        if (i < objects.Length){
            Console.WriteLine("You've fallen into " + objects[i]);
            if(objects[i] == "dark wet pit"){
                myLostLife.LoseLife();
            }
        }
        else{
            Console.WriteLine("Your path is clear! Find your way out!");
        }
        
    }
    public LifeCount myLostLife = new LifeCount();

}