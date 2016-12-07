
using System;
public class LifeCount{
   private int lives = 4;
     public void LoseLife(){
        if (lives > 0){
            lives--;
        Console.WriteLine ("uh oh, you have " + lives + " lives left. Try not to die again.");
        }
        else {
            GameStatusBase.currentGamestatus = GameStatusBase.GameStates.End;
        }
    }

}