namespace RTChess.Logic;
using System;
using System.Threading.Tasks;
public class MoveTile : IPiece
{
    public int Offset { get; set; }
    public bool Row { get; set; }
    public bool Pawn { get; set; } = false;
    public bool RightOrLeft { get; set; }
    public IPiece Creator { get; set; }

    public MoveTile(IPiece creator, bool color, int direction, int location, bool extend, bool initial) : base(color, location)
    {
        DateTime date = new DateTime(2006, 06, 10, 0, 0, 0);
        LastMoved = date;

        Creator = creator;
        this.Display = 't';
        switch (direction)
        {
            case 0://Rook
                Offset = 8;
                break;
            case 1:
                Offset = 1;
                Row = true;
                RightOrLeft = true;
                break;
            case 2:
                Offset = -8;
                break;
            case 3:
                Offset = -1;
                Row = true;
                RightOrLeft = false;
                break;
            case 4://Bishop
                Offset = 9;
                Row = true;
                RightOrLeft = true;
                break;
            case 5:
                Offset = 7;
                Row = true;
                RightOrLeft = false;
                break;
            case 6:
                Offset = -7;
                Row = true;
                RightOrLeft = true;
                break;
            case 7:
                Offset = -9;
                Row = true;
                RightOrLeft = false;
                break;
            case 8://Knight
                Offset = 17;
                Row = true;
                RightOrLeft = true;
                break;
            case 9:
                Offset = 15;
                Row = true;
                RightOrLeft = false;
                break;
            case 10:
                Offset = 10;
                Row = true;
                RightOrLeft = true;
                break;
            case 11:
                Offset = 6;
                Row = true;
                RightOrLeft = false;
                break;
            case 12:
                Offset = -17;
                Row = true;
                RightOrLeft = false;
                break;
            case 13:
                Offset = -15;
                Row = true;
                RightOrLeft = true;
                break;
            case 14:
                Offset = -10;
                Row = true;
                RightOrLeft = false;
                break;
            case 15:
                Offset = -6;
                Row = true;
                RightOrLeft = true;
                break;
            //Pawns >:(
            case 16:
                if (color)
                {
                    Offset = 8;
                }
                else
                {
                    Offset = -8;
                }
                Pawn = true;
                break;
            case 17:
                if (color)
                {
                    Offset = 16;
                }
                else
                {
                    Offset = -16;
                }
                Pawn = true;
                break;
            case 18:
                if (color)
                {
                    Offset = 7;
                }
                else
                {
                    Offset = -7;
                }
                Pawn = true;
                break;
            case 19:
                if (color)
                {
                    Offset = 9;
                }
                else
                {
                    Offset = -9;
                }
                Pawn = true;
                break;
        }
        if (initial)
        {

            if (location < 64 - Offset && location > 0 - Offset)
            {
                if (!extend && Board.GameBoard[location + Offset] == null)
                {
                    if (!Pawn)
                    {
                        Board.Move(creator, color, direction, location + Offset, false);
                    }
                    else if (Offset == 8 || Offset == 16 || Offset == -8 || Offset == -16)
                    {
                        Board.Move(creator, color, direction, location + Offset, false);
                    }
                }
                else if (!extend && Board.GameBoard[location + Offset].Color != color)
                    if (!Row || !(RightOrLeft && location % 8 == 7) && !(Offset < 0 && location % 8 == 0))
                    {
                        if (!Pawn)
                        {
                            //Capturing Pieces(see below)
                            Board.GameBoard[location + Offset].InDanger = true;
                            Board.GameBoard[location + Offset].DangerBy = Creator;
                        }
                        else if (Offset == 7 || Offset == 9 || Offset == -7 || Offset == -9)
                        {
                            Board.GameBoard[location + Offset].InDanger = true;
                            Board.GameBoard[location + Offset].DangerBy = Creator;
                        }
                    }
            }
        }
        if (location < 64 - Offset && location > 0 - Offset && !Pawn)
        {
            if (extend && Board.GameBoard[location + Offset] == null)
            {
                if (!Row || !((RightOrLeft) && Offset != 7 && location % 8 == 7) && !((!RightOrLeft) && Offset != -7 && location % 8 == 0))
                {
                    Board.Move(creator, color, direction, location + Offset, extend);
                }
            }
            //Capturing Pieces (see above)
            else if (extend && Board.GameBoard[location + Offset].Color != color)
                if (!Row || !(Offset > 0 && location % 8 == 7) && !(Offset < 0 && location % 8 == 0))
                {
                    Board.GameBoard[location + Offset].InDanger = true;
                    Board.GameBoard[location + Offset].DangerBy = Creator;
                }
        }

    }


    override public void Move()
    {
        Creator.LastMoved = DateTime.Now;
        if (Color)
        {
            Board.MoveTilesWhite.Remove(this);
        }
        else
        {
            Board.MoveTilesBlack.Remove(this);
        }
        Board.GameBoard[Position] = Creator;
        Board.GameBoard[Creator.Position] = null;
        Creator.Position = Position;
        Board.RemoveMoves(!Color);
    }
}
