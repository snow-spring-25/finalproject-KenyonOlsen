namespace RTChess.Logic;
//REQ#2.2.1
public class Bishop : IPiece
{
    int preDisplay = (int)'♗';

    public Bishop(bool color, int Position) : base(color, Position)
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
            Board.Move(this, Color, 4, Position, true, true);
            Board.Move(this, Color, 5, Position, true, true);
            Board.Move(this, Color, 6, Position, true, true);
            Board.Move(this, Color, 7, Position, true, true);
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
