namespace RTChess.Logic;

public class Board
{
    public Board()
    {
    }
    public IPiece WRook1 = new Rook(true);
    public IPiece WRook2 = new Rook(true);
    public IPiece WKnight1 = new Knight(true);
    public IPiece WKnight2 = new Knight(true);
    public IPiece WBishop1 = new Bishop(true);
    public IPiece WBishop2 = new Bishop(true);
    public IPiece WKing = new King(true);
    public IPiece WQueen = new Queen(true);
    public IPiece BRook1 = new Rook(false);
    public IPiece BRook2 = new Rook(false);
    public IPiece BKnight1 = new Knight(false);
    public IPiece BKnight2 = new Knight(false);
    public IPiece BBishop1 = new Bishop(false);
    public IPiece BBishop2 = new Bishop(false);
    public IPiece BKing = new King(false);
    public IPiece BQueen = new Queen(false);
    public IPiece Null = null;
    public IPiece[] GameStart()
    {
        IPiece[] nullRow = { Null, Null, Null, Null, Null, Null, Null, Null };
        IPiece[] GameBoard = { WRook1, WKnight1, WBishop1, WKing, WQueen, WBishop2, WKnight2, WRook2,
        null, null, null, null, null, null, null, null,
        null, null, null, null, null, null, null, null,
        null, null, null, null, null, null, null, null,
        null, null, null, null, null, null, null, null,
        null, null, null, null, null, null, null, null,
        null, null, null, null, null, null, null, null,
        BRook1, BKnight1, BBishop1, BKing, BQueen, BBishop2, BKnight2, BRook2 };
        return GameBoard;
    }
}


