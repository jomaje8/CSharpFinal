using System;
public class LevelBase {
    public LevelBase () {
        Game.StartGame += RunLevel;
    }

    private void RunLevel()
    {
        Console.WriteLine ("Welcome!");
    }
}