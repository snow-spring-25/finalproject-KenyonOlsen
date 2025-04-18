namespace RTChess.Logic;

public class Board
{
    public Board()
    {
    }
    public static List<MoveTile> MoveTiles = new List<MoveTile>();
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

    public static IPiece WPawn1 = new Pawn(true, 8);
    public static IPiece WPawn2 = new Pawn(true, 9);
    public static IPiece WPawn3 = new Pawn(true, 10);
    public static IPiece WPawn4 = new Pawn(true, 11);
    public static IPiece WPawn5 = new Pawn(true, 12);
    public static IPiece WPawn6 = new Pawn(true, 13);
    public static IPiece WPawn7 = new Pawn(true, 14);
    public static IPiece WPawn8 = new Pawn(true, 15);
    public static IPiece BPawn1 = new Pawn(false, 48);
    public static IPiece BPawn2 = new Pawn(false, 49);
    public static IPiece BPawn3 = new Pawn(false, 50);
    public static IPiece BPawn4 = new Pawn(false, 51);
    public static IPiece BPawn5 = new Pawn(false, 52);
    public static IPiece BPawn6 = new Pawn(false, 53);
    public static IPiece BPawn7 = new Pawn(false, 54);
    public static IPiece BPawn8 = new Pawn(false, 55);
    public static IPiece Null = null;

    /*public static IPiece?[] GameBoard =  { WRook1, WKnight1, WBishop1, WKing, WQueen, WBishop2, WKnight2, WRook2,
        WPawn1, WPawn2, WPawn3, WPawn4, WPawn5, WPawn6, WPawn7, WPawn8,
        null, null, null, null, null, null, null, null ,
        null, null, null, null, null, null, null, null ,
        null, null, null, null, null, null, null, null ,
        null, null, null, null, null, null, null, null ,
        BPawn1, BPawn2, BPawn3, BPawn4, BPawn5, BPawn6, BPawn7, BPawn8,
        BRook1, BKnight1, BBishop1, BKing, BQueen, BBishop2, BKnight2, BRook2 };
        */

    public static IPiece?[] GameBoard =  { WRook1, WKnight1, WBishop1, WKing, WQueen, WBishop2, WKnight2, WRook2,
        null, null, null, null, null, null, null, null ,
        null, null, null, null, null, null, null, null ,
        null, null, null, null, null, null, null, null ,
        null, null, null, null, null, null, null, null ,
        null, null, null, null, null, null, null, null ,
        null, null, null, null, null, null, null, null ,
        BRook1, BKnight1, BBishop1, BKing, BQueen, BBishop2, BKnight2, BRook2 };


    public static void Move(IPiece creator, bool color, int Direction, int Location, bool Extend)
    {
        MoveTile m = new MoveTile(creator, color, Direction, Location, Extend);

        GameBoard[Location] = m;
        MoveTiles.Add(m);
    }

    public static void Move(IPiece creator, bool color, int Direction, int Location, bool Extend, bool Initial)
    {
        MoveTile m = new MoveTile(creator, color, Direction, Location, Extend, Initial);
        //MoveTiles.Add(m);
    }

    public static void RemoveMoves()
    {
        foreach (MoveTile tile in MoveTiles)
        {
            GameBoard[tile.Position] = null;
            
        }

        for(int i = 0; i < MoveTiles.Count();i++)
        {
            MoveTiles[0] = null;
            MoveTiles.RemoveAt(0);
        }
    }
}

