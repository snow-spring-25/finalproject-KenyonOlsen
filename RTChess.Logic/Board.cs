namespace RTChess.Logic;

public class Board
{
    public Board()
    {
    }
    public static IPiece WRook1 = new Rook(true);
    public static IPiece WRook2 = new Rook(true);
    public static IPiece WKnight1 = new Knight(true);
    public static IPiece WKnight2 = new Knight(true);
    public static IPiece WBishop1 = new Bishop(true);
    public static IPiece WBishop2 = new Bishop(true);
    public static IPiece WKing = new King(true);
    public static IPiece WQueen = new Queen(true);
    public static IPiece BRook1 = new Rook(false);
    public static IPiece BRook2 = new Rook(false);
    public static IPiece BKnight1 = new Knight(false);
    public static IPiece BKnight2 = new Knight(false);
    public static IPiece BBishop1 = new Bishop(false);
    public static IPiece BBishop2 = new Bishop(false);
    public static IPiece BKing = new King(false);
    public static IPiece BQueen = new Queen(false);
    public static IPiece Null = null;
    public static IPiece?[] GameBoard =  { WRook1, WKnight1, WBishop1, WKing, WQueen, WBishop2, WKnight2, WRook2,
        null, null, null, null, null, null, null, null,
        null, null, null, null, null, null, null, null ,
        null, null, null, null, null, null, null, null ,
        null, null, null, null, null, null, null, null ,
        null, null, null, null, null, null, null, null ,
        null, null, null, null, null, null, null, null ,
        BRook1, BKnight1, BBishop1, BKing, BQueen, BBishop2, BKnight2, BRook2 };

    public static void Move(bool color, int Direction, int Location)
    {
        MoveTile m = new MoveTile(color, Direction, Location);

        GameBoard[Location] = m;
    }
}

