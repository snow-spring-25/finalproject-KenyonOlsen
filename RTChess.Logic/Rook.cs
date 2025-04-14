namespace RTChess.Logic;

public class Rook : IPiece
{
    int preDisplay = (int)'♖';
    public Rook(bool color) : base(color)
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