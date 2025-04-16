namespace RTChess.Logic;

public class Queen : IPiece
{
    int preDisplay = (int)'♕';
    public Queen(bool color, int Position) : base(color, Position)
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
        Board.Move(true, 0, this.Position, true, true);
        Board.Move(true, 1, this.Position, true, true);
        Board.Move(true, 2, this.Position, true, true);
        Board.Move(true, 3, this.Position, true, true);
        Board.Move(true, 4, this.Position, true, true);
        Board.Move(true, 5, this.Position, true, true);
        Board.Move(true, 6, this.Position, true, true);
        Board.Move(true, 7, this.Position, true, true);
    }
}