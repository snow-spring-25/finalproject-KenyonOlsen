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
        if (DateTime.Now > this.LastMoved.AddSeconds(CooldownSeconds))
        {
            Board.Move(this, this.Color, 0, this.Position, false, true);
            Board.Move(this, this.Color, 1, this.Position, false, true);
            Board.Move(this, this.Color, 2, this.Position, false, true);
            Board.Move(this, this.Color, 3, this.Position, false, true);
            Board.Move(this, this.Color, 4, this.Position, false, true);
            Board.Move(this, this.Color, 5, this.Position, false, true);
            Board.Move(this, this.Color, 6, this.Position, false, true);
            Board.Move(this, this.Color, 7, this.Position, false, true);
        }
    }
}