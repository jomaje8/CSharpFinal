using System;
public class LevelBase {
    public LevelBase () {
        public static string StartMessage;
        public string[] enviornment;
        public string[] itemsAvailable;
        
    }

    private void RunLevel()
    {
        Console.WriteLine (LevelBase.StartMessage);
    }
}