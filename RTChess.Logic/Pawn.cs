namespace RTChess.Logic;

public class Pawn : IPiece
{
    int preDisplay = (int)'♙';
    public Pawn(bool color) : base(color)
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
}