namespace RTChess.Logic;

public class IPiece
{
    public bool Color { get; set; }
    public char Display { get; set; }
    public bool Dead { get; set; }
    public int CooldownSeconds { get; set; } = 1;
    public bool OnCooldown { get; set; } = false;
    public int Position { get; set; }
    public DateTime LastMoved { get; set; }
    public bool InDanger { get; set; }
    public IPiece DangerBy { get; set; }

    public IPiece(bool color, int position) : this(color)
    {
        Position = position;
    }
    public IPiece(bool color, char display) : this(color)
    {
        Display = display;
    }
    public IPiece(bool color)
    {
        Color = color;
    }

    virtual public void Move()
    {

    }

    virtual public void Capture()
    {

    }
}
