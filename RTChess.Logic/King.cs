namespace RTChess.Logic;

public class Knight : IPiece
{
    int preDisplay = (int)'♘';
    public Knight(bool color, int Position) : base(color, Position)
    {
        if (color)
        {
            preDisplay += 6;
            Display = (char)preDisplay;
        }
        else
        {
            Display = (char)preDisplay;
        }
    }

    override public void Move()
    {
        if (DateTime.Now > this.LastMoved.AddSeconds(CooldownSeconds))
        {
            //Can go across the board when overflowing a row
            Board.Move(this, Color, 8, Position, false, true);
            Board.Move(this, Color, 9, Position, false, true);
            Board.Move(this, Color, 10, Position, false, true);
            Board.Move(this, Color, 11, Position, false, true);
            Board.Move(this, Color, 12, Position, false, true);
            Board.Move(this, Color, 13, Position, false, true);
            Board.Move(this, Color, 14, Position, false, true);
            Board.Move(this, Color, 15, Position, false, true);
        }
    }

    override public void Capture()
    {
        DangerBy.LastMoved = DateTime.Now;
        Board.GameBoard[Position] = DangerBy;
        Board.GameBoard[DangerBy.Position] = null;
        DangerBy.Position = Position;
        Board.RemoveMoves(Color);
    }
}
