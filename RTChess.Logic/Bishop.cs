namespace RTChess.Logic;

public class Bishop : IPiece
{
    int preDisplay = (int)'♗';

    public Bishop(bool color, int Position) : base(color, Position)
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
        Board.Move(true, 4, this.Position, true, true);
        Board.Move(true, 5, this.Position, true, true);
        Board.Move(true, 6, this.Position, true, true);
        Board.Move(true, 7, this.Position, true, true);
    }
}