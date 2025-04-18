namespace RTChess.Logic;

public class MoveTile : IPiece
{
    public int Offset { get; set; }
    public bool Row { get; set; }

    public MoveTile(bool color, int Direction, int Location, bool Extend) : base(color)
    {
        this.Display = 't';
        switch (Direction)
        {
            case 0://Rook
                Offset = 8;
                break;
            case 1:
                Offset = 1;
                Row = true;
                break;
            case 2:
                Offset = -8;
                break;
            case 3:
                Offset = -1;
                Row = true;
                break;
            case 4://Bishop
                Offset = 9;
                Row = true;
                break;
            case 5:
                Offset = 7;
                Row = true;
                break;
            case 6:
                Offset = -7;
                Row = true;
                break;
            case 7:
                Offset = -9;
                Row = true;
                break;
            case 8://Knight
                Offset = 17;
                Row = true;
                break;
            case 9:
                Offset = 15;
                Row = true;
                break;
            case 10:
                Offset = 10;
                Row = true;
                break;
            case 11:
                Offset = 6;
                Row = true;
                break;
            case 12:
                Offset = -17;
                Row = true;
                break;
            case 13:
                Offset = -15;
                Row = true;
                break;
            case 14:
                Offset = -10;
                Row = true;
                break;
            case 15:
                Offset = -6;
                Row = true;
                break;
        }
        if (Location < 64 - Offset && Location > 0 - Offset)
        {
            if (Extend && Board.GameBoard[Location + Offset] == null && (!Row || Location % 8 != 7 && Location % 8 != 0))
            {
                Board.Move(color, Direction, Location + Offset, Extend);
            }
            /*else if (Extend && Board.GameBoard[Location + Offset] == Board.GameBoard[Location + Offset].Color!=this.Color && (!Row || Location % 8 != 7 && Location % 8 != 0))
            {
                Board.Move(color, Direction, Location + Offset, false);
            }*/
        }
        
    }
    public MoveTile(bool color, int Direction, int Location, bool Extend, bool Initial) : this(color, Direction, Location, Extend)
    {
        if (Location < 64 - Offset && Location > 0 - Offset)
        {
            if (!Extend && Board.GameBoard[Location + Offset] == null && (!Row || Location % 8 != 7 && Location % 8 != 0))
            {
                Board.Move(color, Direction, Location + Offset, false);
            }
        }
    }

}