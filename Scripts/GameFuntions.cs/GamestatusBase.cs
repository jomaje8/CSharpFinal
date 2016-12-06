public class GameStatusBase{
    public enum GameStates {start, End, Fight, play, Continue, Run, Died, help}

    public static GameStates currentGamestatus = GameStates.start;    
}