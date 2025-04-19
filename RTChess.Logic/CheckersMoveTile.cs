namespace RTChess.Logic;
using System;
using System.Threading.Tasks;
public class CheckersMoveTile : IPiece
{
    public int Offset { get; set; }
    public bool Row { get; set; }
    public IPiece Creator { get; set; }


    public CheckersMoveTile(IPiece creator, bool color, int direction, int location, bool extend, bool initial) : base(color, location)
    {

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
                //Row = true;
                break;
            case 9:
                Offset = 15;
                //Row = true;
                break;
            case 10:
                Offset = 10;
                //Row = true;
                break;
            case 11:
                Offset = 6;
                //Row = true;
                break;
            case 12:
                Offset = -17;
                //Row = true;
                break;
            case 13:
                Offset = -15;
                //Row = true;
                break;
            case 14:
                Offset = -10;
                //Row = true;
                break;
            case 15:
                Offset = -6;
                //Row = true;
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
                break;
        }
        if (initial)
        {

            if (location < 64 - Offset && location > 0 - Offset)
            {
                if (!extend && CheckersBoard.GameBoard[location + Offset] == null)
                {
                        CheckersBoard.Move(creator, color, direction, location + Offset, false);
                }
                else if (!extend && CheckersBoard.GameBoard[location + Offset].Color != color)
                    if (!Row || !(Offset > 0 && location % 8 == 7) && !(Offset < 0 && location % 8 == 0))
                    {

                        //Capturing Pieces(see below)
                        CheckersBoard.GameBoard[location + Offset].InDanger = true;
                        CheckersBoard.GameBoard[location + Offset].DangerBy = Creator;
                    }
            }
        }
        if (location < 64 - Offset && location > 0 - Offset)
        {
            if (extend && CheckersBoard.GameBoard[location + Offset] == null)
            {
                if (!Row || !(Offset > 0 && location % 8 == 7) && !(Offset < 0 && location % 8 == 0))
                {
                    CheckersBoard.Move(creator, color, direction, location + Offset, extend);
                }
            }
            //Capturing Pieces (see above)
            else if (extend && CheckersBoard.GameBoard[location + Offset].Color != color)
                if (!Row || !(Offset > 0 && location % 8 == 7) && !(Offset < 0 && location % 8 == 0))
                {
                    CheckersBoard.GameBoard[location + Offset].InDanger = true;
                    CheckersBoard.GameBoard[location + Offset].DangerBy = Creator;
                }
        }

    }


    override public void Move()
    {
        Creator.LastMoved = DateTime.Now;
        CheckersBoard.CheckersMoveTiles.Remove(this);
        CheckersBoard.GameBoard[Position] = Creator;
        CheckersBoard.GameBoard[Creator.Position] = null;
        Creator.Position = Position;
        CheckersBoard.RemoveMoves();
    }
}
