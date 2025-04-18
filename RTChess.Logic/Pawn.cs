namespace RTChess.Logic;

public class Pawn : IPiece
{
    int preDisplay = (int)'♙';
    public Pawn(bool color, int Position) : base(color, Position)
    {
        if (color)
        {
            preDisplay += 6;
            this.Display = (char)preDisplay;
        }
        else
        {
            this.Display = (char)preDisplay;
        }
    }

    override public void Move()
    {
        if (DateTime.Now > this.LastMoved.AddSeconds(CooldownSeconds))
        {

        }
    }
}