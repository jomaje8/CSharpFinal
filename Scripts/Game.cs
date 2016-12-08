using System;
public class Game
{
    public int health;
    public static PlayerBase player = new PlayerBase();
    public static WeaponBase weapon = new WeaponBase();
    public static Action StartGame;
    public static bool canPlay = true;
       public void Start()
    {}

        private string gameStatus = "start";
    public GameStatusBase.GameStates toEnum;
    private void Continue()
    {

        switch (toEnum)
        {
            case GameStatusBase.GameStates.End:
                Console.WriteLine("Game OVER!");
                Environment.Exit(0);
                break;
            case GameStatusBase.GameStates.Died:
                Console.WriteLine("Ah, you died!! That sucks.");
                GameStatusBase.currentGamestatus = GameStatusBase.GameStates.End;
                Continue();
                break;
            case GameStatusBase.GameStates.play:
                GameStatusBase.currentGamestatus = GameStatusBase.GameStates.Continue;
                gameStatus = Console.ReadLine();
                if (Enum.TryParse(gameStatus, out toEnum))
                    Continue();
                break;
            case GameStatusBase.GameStates.start:
                Console.WriteLine("Do you Accept the your mission?   " + " Type play. or help, for help");
                gameStatus = Console.ReadLine();
                if (Enum.TryParse(gameStatus, out toEnum))
                    GameStatusBase.currentGamestatus = GameStatusBase.GameStates.Fight;
                Continue();
                break;
            case GameStatusBase.GameStates.help:
                Console.WriteLine("Type play, that will help.");
                GameStatusBase.currentGamestatus = GameStatusBase.GameStates.start;
                Continue();
                break;
            case GameStatusBase.GameStates.Fight:
                while (true)
                {
                    Cave.Enter();
                    Random randomNum = new Random();
                    // This is supposed to name Cave as a new level, Then you try to do the level.
                    GameTimer();
                    Continue();
                }
                break;
            default:
                Console.WriteLine("I'm sorry i don't understand what that means.");
                Continue();
                break;
             }

        }

           private LevelBase Cave = new LevelBase();

// game timer
   public static void GameTimer () {
        System.Threading.Thread.Sleep(2000);
    }
    public int score;

    }
    

