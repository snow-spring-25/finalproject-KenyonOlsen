namespace RTChess.Logic;

public class Rook : IPiece
{
    int preDisplay = (int)'♖';
    public Rook(bool color, int Position) : base(color, Position)
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
    }
}