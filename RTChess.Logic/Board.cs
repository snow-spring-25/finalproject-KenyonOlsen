namespace RTChess.Logic;

public class Board
{
    public Board()
    {
    }
    public static IPiece WRook1 = new Rook(true, 0);
    public static IPiece WRook2 = new Rook(true, 7);
    public static IPiece WKnight1 = new Knight(true, 1);
    public static IPiece WKnight2 = new Knight(true, 6);
    public static IPiece WBishop1 = new Bishop(true, 2);
    public static IPiece WBishop2 = new Bishop(true, 5);
    public static IPiece WKing = new King(true, 3);
    public static IPiece WQueen = new Queen(true, 4);
    public static IPiece BRook1 = new Rook(false, 56);
    public static IPiece BRook2 = new Rook(false, 63);
    public static IPiece BKnight1 = new Knight(false, 57);
    public static IPiece BKnight2 = new Knight(false, 62);
    public static IPiece BBishop1 = new Bishop(false, 58);
    public static IPiece BBishop2 = new Bishop(false, 61);
    public static IPiece BKing = new King(false, 59);
    public static IPiece BQueen = new Queen(false, 60);
    public static IPiece Null = null;
    public static IPiece?[] GameBoard =  { WRook1, WKnight1, WBishop1, WKing, WQueen, WBishop2, WKnight2, WRook2,
        null, null, null, null, null, null, null, null,
        null, null, null, null, null, null, null, null ,
        null, null, null, null, null, null, null, null ,
        null, null, null, null, null, null, null, null ,
        null, null, null, null, null, null, null, null ,
        null, null, null, null, null, null, null, null ,
        BRook1, BKnight1, BBishop1, BKing, BQueen, BBishop2, BKnight2, BRook2 };

    public static void Move(bool color, int Direction, int Location, bool Extend)
    {
        MoveTile m = new MoveTile(color, Direction, Location, Extend);

        GameBoard[Location] = m;
    }

    public static void Move(bool color, int Direction, int Location, bool Extend, bool Initial)
    {
        MoveTile m = new MoveTile(color, Direction, Location, Extend, Initial);
    }
}

