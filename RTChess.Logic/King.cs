namespace RTChess.Logic;

public class King : IPiece
{
    int preDisplay = (int)'♔';
    public King(bool color, int Position) : base(color, Position)
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
        Board.Move(true, 0, this.Position, false, true);
        Board.Move(true, 1, this.Position, false, true);
        Board.Move(true, 2, this.Position, false, true);
        Board.Move(true, 3, this.Position, false, true);
        Board.Move(true, 4, this.Position, false, true);
        Board.Move(true, 5, this.Position, false, true);
        Board.Move(true, 6, this.Position, false, true);
        Board.Move(true, 7, this.Position, false, true);
    }
}