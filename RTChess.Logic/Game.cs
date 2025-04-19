namespace RTChess.Logic;
public class Game
{
    public Player P1 { get; set; }
    public Player P2 { get; set; }
    public Board PlayBoard { get; set; }

    public Game(Player p1, Player p2)
    {
        P1 = p1;
        P2 = p2;
        PlayBoard = new Board();
    }
}
