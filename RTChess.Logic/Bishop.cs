namespace RTChess.Logic;

public class Bishop : IPiece
{
    int preDisplay = (int)'♗';

    public Bishop(bool color) : base(color)
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