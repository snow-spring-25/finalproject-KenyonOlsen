namespace RTChess.Logic;

public class IPiece
{
    public bool Color { get; set; }
    public char Display { get; set; }
    public bool Dead { get; set; }
    public int Cooldown { get; set; }

    public IPiece(bool color, char display)
    {
        Color = color;
        Display = display;
    }
    public IPiece(bool color)
    {
        Color = color;
    }

    void Move()
    {

    }
}
