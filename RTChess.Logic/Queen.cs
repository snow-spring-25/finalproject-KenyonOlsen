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
        Board.Move(this.Color, 0, this.Position, true, true);
        Board.Move(this.Color, 1, this.Position, true, true);
        Board.Move(this.Color, 2, this.Position, true, true);
        Board.Move(this.Color, 3, this.Position, true, true);
        Board.Move(this.Color, 4, this.Position, true, true);
        Board.Move(this.Color, 5, this.Position, true, true);
        Board.Move(this.Color, 6, this.Position, true, true);
        Board.Move(this.Color, 7, this.Position, true, true);
    }
}