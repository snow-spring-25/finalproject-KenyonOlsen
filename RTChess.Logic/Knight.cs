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
        //Can go across the board when overflowing a row
        Board.Move(this, this.Color, 8, this.Position, false, true);
        Board.Move(this, this.Color, 9, this.Position, false, true);
        Board.Move(this, this.Color, 10, this.Position, false, true);
        Board.Move(this, this.Color, 11, this.Position, false, true);
        Board.Move(this, this.Color, 12, this.Position, false, true);
        Board.Move(this, this.Color, 13, this.Position, false, true);
        Board.Move(this, this.Color, 14, this.Position, false, true);
        Board.Move(this, this.Color, 15, this.Position, false, true);
    }
}