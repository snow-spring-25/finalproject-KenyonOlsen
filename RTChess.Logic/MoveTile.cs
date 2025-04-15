namespace RTChess.Logic;

public class MoveTile : IPiece
{
    public int Offset { get; set; }
    public bool Row { get; set; }
    //Board.GameBoard[Location] = this;

    //IPiece[] GameBoard = Board.GameStart();
    public MoveTile(bool color, int Direction, int Location) : base(color)
    {
        this.Display = 't';
        switch (Direction)
        {
            case 0:
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
        }
        if (Location < 64 - Offset && Board.GameBoard[Location + Offset] == null && (!Row || Location % 8 != 7 && Location % 8 != 0))
        {
            Board.Move(color, Direction, Location + Offset);

        }
        //else if (Location < 64 - Offset && Board.GameBoard[Location + Offset].Color != color)
        //{
        //Board.Move(color, Direction, Location + Offset);

        //}
    }

    public void Move()
    {

    }

}