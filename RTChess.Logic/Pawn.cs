namespace RTChess.Logic;

public class Pawn : IPiece
{
    int preDisplay = (int)'♙';
    public Pawn(bool color, int Position) : base(color, Position)
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
            Board.Move(this, Color, 16, Position, false, true);
            if ((Color && Position < 16) || (!Color && Position > 48))
            {
                Board.Move(this, this.Color, 17, this.Position, false, true);
            }
            Board.Move(this, Color, 18, Position, false, true);
            Board.Move(this, Color, 19, Position, false, true);
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
