namespace RTChess.Logic;

public class Knight : IPiece
{
    int preDisplay = (int)'♘';
    public Knight(bool color) : base(color)
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