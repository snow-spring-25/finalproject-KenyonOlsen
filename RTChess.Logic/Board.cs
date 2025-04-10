namespace RTChess.Logic;

public class Board
{
    public Board()
    {
    }
    public IPiece WRook1 = new Rook(false);
    public IPiece WRook2 = new Rook(false);
    public IPiece WKnight1 = new Knight(false);
    public IPiece WKnight2 = new Knight(false);
    public IPiece WBishop1 = new Bishop(false);
    public IPiece WBishop2 = new Bishop(false);
    public IPiece WKing = new King(false);
    public IPiece WQueen = new Queen(false);
    public IPiece BRook1 = new Rook(true);
    public IPiece BRook2 = new Rook(true);
    public IPiece BKnight1 = new Knight(true);
    public IPiece BKnight2 = new Knight(true);
    public IPiece BBishop1 = new Bishop(true);
    public IPiece BBishop2 = new Bishop(true);
    public IPiece BKing = new King(true);
    public IPiece BQueen = new Queen(true);
    public object[] GameBoard = { WRook1, WKnight1, WBishop1, WKing, WQueen, WBishop2, WKnight2, WRook2, BRook1, BKnight1, BBishop1, BKing, BQueen, BBishop2, BKnight2, BRook2 };
}


