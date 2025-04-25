namespace RTChess.Logic;
//REQ#2.2.1
public class IPiece //REQ#2.2.1
{
    public bool Color { get; set; }
    public char Display { get; set; }
    public bool Dead { get; set; }
    public static int CooldownSeconds { get; set; } = 1;
    public bool OnCooldown { get; set; } = false;
    public decimal CooldownPercent { get; set; }
    public int Position { get; set; }
    public DateTime LastMoved { get; set; } = DateTime.Now;
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

    public double GetCooldownPercent()
    {
        TimeSpan span = DateTime.Now - LastMoved;
        //Console.WriteLine(span);
        double seconds = span.TotalSeconds;
        seconds /= CooldownSeconds;
        //Console.WriteLine(seconds);
        return seconds;
    }

    virtual public void Move()
    {

    }

    virtual public void Capture()
    {

    }
}
