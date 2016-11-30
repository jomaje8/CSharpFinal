using System;
public class LevelBase {
    public LevelBase () {
        public string StartMessage;
        public string[] enviornment;
        public string[] itemsAvailable;
        Game.StartGame += RunLevel;
    }

    private void RunLevel()
    {
        Console.WriteLine (StartMessage);
    }
}