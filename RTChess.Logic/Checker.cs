namespace RTChess.Logic;

public class Checker : IPiece
{
    int preDisplay = (int)'●';
    public Checker(bool color, int Position) : base(color, Position)
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
        //if (DateTime.Now > this.LastMoved.AddSeconds(CooldownSeconds))
        //{
            if (Color)
            {
                CheckersBoard.Move(this, Color, 4, Position, false, true);
                CheckersBoard.Move(this, Color, 5, Position, false, true);
            }
           else
            {
                CheckersBoard.Move(this, Color, 6, Position, false, true);
                CheckersBoard.Move(this, Color, 7, Position, false, true);
            }
        //}
    }

    override public void Capture()
    {
        DangerBy.LastMoved = DateTime.Now;
        CheckersBoard.GameBoard[Position] = DangerBy;
        CheckersBoard.GameBoard[DangerBy.Position] = null;
        DangerBy.Position = Position;
        CheckersBoard.RemoveMoves();
        CheckersBoard.EndGame(!Color);
    }
}