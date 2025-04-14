namespace RTChess.Logic;

public class King : IPiece
{
    int preDisplay = (int)'♔';
    public King(bool color) : base(color)
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