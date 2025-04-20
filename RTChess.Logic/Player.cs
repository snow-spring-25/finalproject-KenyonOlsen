namespace RTChess.Logic;

public class Player
{
    public string Name { get; set; }
    public bool Color { get; set; }
    public int Wins { get; set; }

    public Player(bool color)
    {
        Color = color;
    }
}
