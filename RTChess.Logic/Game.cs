namespace RTChess.Logic;
public class Game
{
    public static Player P1 { get; set; } = new Player(true);
    public static Player P2 { get; set; } = new Player(false);

    //public Game(Player p1, Player p2)
    //{
    //    P1 = p1;
    //    P2 = p2;
    //}
}
