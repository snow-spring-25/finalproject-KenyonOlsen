namespace RTChess.Logic;

public class Knight : IPiece
{
    int preDisplay = (int)'♘';
    public Knight(bool color, int Position) : base(color, Position)
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
        Board.Move(true, 8, this.Position, false, true);
        Board.Move(true, 9, this.Position, false, true);
        Board.Move(true, 10, this.Position, false, true);
        Board.Move(true, 11, this.Position, false, true);
        Board.Move(true, 12, this.Position, false, true);
        Board.Move(true, 13, this.Position, false, true);
        Board.Move(true, 14, this.Position, false, true);
        Board.Move(true, 15, this.Position, false, true);
    }
}