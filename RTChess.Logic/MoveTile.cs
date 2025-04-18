namespace RTChess.Logic;

public class MoveTile : IPiece
{
    public int Offset { get; set; }
    public bool Row { get; set; }
    public IPiece Creator { get; set; }

    public MoveTile(IPiece creator, bool color, int direction, int location, bool extend, bool initial) : base(color, location)
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
        }
        if (initial)
        {

            if (location < 64 - Offset && location > 0 - Offset)
            {
                if (!extend && Board.GameBoard[location + Offset] == null)
                {
                    Board.Move(creator, color, direction, location + Offset, false);
                }
            }
        }
        if (location < 64 - Offset && location > 0 - Offset)
        {
            if (extend && Board.GameBoard[location + Offset] == null)
            {
                if (!Row || !(Offset > 0 && location % 8 == 7) && !(Offset < 0 && location % 8 == 0))
                {
                    Board.Move(creator, color, direction, location + Offset, extend);
                }
            }
            /*else if (Extend && Board.GameBoard[Location + Offset] == Board.GameBoard[Location + Offset].Color!=this.Color && (!Row || Location % 8 != 7 && Location % 8 != 0))
            {
                Board.Move(color, Direction, Location + Offset, false);
            }*/
        }

    }


    override public void Move()
    {
        Creator.LastMoved = DateTime.Now;
        Board.MoveTiles.Remove(this);
        Board.GameBoard[this.Position] = Creator;
        Board.GameBoard[Creator.Position] = null;
        Creator.Position = this.Position;
        Board.RemoveMoves();
        Creator.OnCooldown = true;
        Task<bool> cooldownEnds = EndCooldownAsync(2);
        //EndCooldownTimer();

    }

    public void EndCooldown()
    {
        Creator.OnCooldown = false;
    }

    static async Task<bool> EndCooldownAsync(int a)
    {
        await EndCooldown();
    }
}