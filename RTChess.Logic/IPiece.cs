namespace RTChess.Logic;

public class IPiece
{
    public bool Color { get; set; }
    public char Display { get; set; }
    public bool Dead { get; set; }
    public int Cooldown { get; set; }
    public int Position { get; set; }

    public IPiece(bool color, int position)
    {
        Color = color;
        Position = position;
    }
    public IPiece(bool color, char display)
    {
        Color = color;
        Display = display;
    }
    public IPiece(bool color)
    {
        Color = color;
    }

    virtual public void Move()
    { 

    }
}
