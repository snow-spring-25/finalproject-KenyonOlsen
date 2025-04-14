namespace RTChess.Logic;

public class Queen : IPiece
{
    int preDisplay = (int)'♕';
    public Queen(bool color) : base(color)
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