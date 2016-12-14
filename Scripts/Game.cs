using System;

public class Game
{
    private LevelBase Level = new LevelBase();
    public static PlayerBase player = new PlayerBase();
    public static WeaponBase weapon = new WeaponBase();
    public void MyGame()
    {
        player.typeSelection();
        player.NameFunction();
        MagicBase.pickPower();
        weapon.GetListOfWeapons();
        Play();
    }
    private string gameFunction = "Start";
    private GameStatusBase.GameStates toEnum;
    public void Play()
    {

        switch (toEnum)
        {
            case GameStatusBase.GameStates.Start:
                Console.WriteLine("To Continue: Play, End");
                gameFunction = Console.ReadLine();
                Console.WriteLine(gameFunction);
                if (Enum.TryParse(gameFunction, out toEnum))
                {
                    Console.WriteLine(toEnum);
                }
                Play();

                break;

            case GameStatusBase.GameStates.End:
                Console.WriteLine("Game Over");
                Environment.Exit(0);
                break;

            case GameStatusBase.GameStates.Play:
                Level.enter();
                Level.Spot(2);
                while (Game.canPlay)
                {
                    GameTimer();
                    Play();

                }
                Play();
                break;

            case GameStatusBase.GameStates.Died:
                Console.WriteLine("You Died");
                Console.WriteLine("Game Over");
                break;

            default:
                Console.WriteLine("This is not a valid option");
                Play();
                break;
        }
        Random randomNum = new Random();
        Level.Spot(randomNum.Next(0, Level.Enemies.Length));
    }
    public void GameTimer()
    {

        System.Threading.Thread.Sleep(2000);
    }
    public static bool canPlay = true;



}
