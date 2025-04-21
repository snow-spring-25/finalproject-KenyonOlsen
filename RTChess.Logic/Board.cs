namespace RTChess.Logic;

public class Board
{
    public Board()
    {
    }

    public static bool GameRunning { get; set; } = true;
    public static bool Winner { get; set; }
    public static List<MoveTile> MoveTilesBlack = new List<MoveTile>();
    public static List<MoveTile> MoveTilesWhite = new List<MoveTile>();
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

    public static IPiece?[] GameBoard =  { WRook1, WKnight1, WBishop1, WKing, WQueen, WBishop2, WKnight2, WRook2,
        WPawn1, WPawn2, WPawn3, WPawn4, WPawn5, WPawn6, WPawn7, WPawn8,
        null, null, null, null, null, null, null, null ,
        null, null, null, null, null, null, null, null ,
        null, null, null, null, null, null, null, null ,
        null, null, null, null, null, null, null, null ,
        BPawn1, BPawn2, BPawn3, BPawn4, BPawn5, BPawn6, BPawn7, BPawn8,
        BRook1, BKnight1, BBishop1, BKing, BQueen, BBishop2, BKnight2, BRook2 };

    /*
        public static IPiece?[] GameBoard =  { WRook1, WKnight1, WBishop1, WKing, WQueen, WBishop2, WKnight2, WRook2,
            null, null, null, null, null, null, null, null ,
            null, null, null, null, null, null, null, null ,
            null, null, null, null, null, null, null, null ,
            null, null, null, null, null, null, null, null ,
            null, null, null, null, null, null, null, null ,
            null, null, null, null, null, null, null, null ,
            BRook1, BKnight1, BBishop1, BKing, BQueen, BBishop2, BKnight2, BRook2 };
    */

    public static void CreateBoard()
    {
        GameRunning = true;
        List<MoveTile> MoveTilesBlack = new List<MoveTile>();
        List<MoveTile> MoveTilesWhite = new List<MoveTile>();
        IPiece WRook1 = new Rook(true, 0);
        IPiece WRook2 = new Rook(true, 7);
        IPiece WKnight1 = new Knight(true, 1);
        IPiece WKnight2 = new Knight(true, 6);
        IPiece WBishop1 = new Bishop(true, 2);
        IPiece WBishop2 = new Bishop(true, 5);
        IPiece WKing = new King(true, 3);
        IPiece WQueen = new Queen(true, 4);
        IPiece BRook1 = new Rook(false, 56);
        IPiece BRook2 = new Rook(false, 63);
        IPiece BKnight1 = new Knight(false, 57);
        IPiece BKnight2 = new Knight(false, 62);
        IPiece BBishop1 = new Bishop(false, 58);
        IPiece BBishop2 = new Bishop(false, 61);
        IPiece BKing = new King(false, 59);
        IPiece BQueen = new Queen(false, 60);

        IPiece WPawn1 = new Pawn(true, 8);
        IPiece WPawn2 = new Pawn(true, 9);
        IPiece WPawn3 = new Pawn(true, 10);
        IPiece WPawn4 = new Pawn(true, 11);
        IPiece WPawn5 = new Pawn(true, 12);
        IPiece WPawn6 = new Pawn(true, 13);
        IPiece WPawn7 = new Pawn(true, 14);
        IPiece WPawn8 = new Pawn(true, 15);
        IPiece BPawn1 = new Pawn(false, 48);
        IPiece BPawn2 = new Pawn(false, 49);
        IPiece BPawn3 = new Pawn(false, 50);
        IPiece BPawn4 = new Pawn(false, 51);
        IPiece BPawn5 = new Pawn(false, 52);
        IPiece BPawn6 = new Pawn(false, 53);
        IPiece BPawn7 = new Pawn(false, 54);
        IPiece BPawn8 = new Pawn(false, 55);

        GameBoard[0] = WRook1;
        GameBoard[1] = WKnight1;
        GameBoard[2] = WBishop1;
        GameBoard[3] = WKing;
        GameBoard[4] = WQueen;
        GameBoard[5] = WBishop2;
        GameBoard[6] = WKnight2;
        GameBoard[7] = WRook2;
        GameBoard[8] = WPawn1;
        GameBoard[9] = WPawn2;
        GameBoard[10] = WPawn3;
        GameBoard[11] = WPawn4;
        GameBoard[12] = WPawn5;
        GameBoard[13] = WPawn6;
        GameBoard[14] = WPawn7;
        GameBoard[15] = WPawn8;
        GameBoard[16] = null;
        GameBoard[17] = null;
        GameBoard[18] = null;
        GameBoard[19] = null;
        GameBoard[20] = null;
        GameBoard[21] = null;
        GameBoard[22] = null;
        GameBoard[23] = null;
        GameBoard[24] = null;
        GameBoard[25] = null;
        GameBoard[26] = null;
        GameBoard[27] = null;
        GameBoard[28] = null;
        GameBoard[29] = null;
        GameBoard[30] = null;
        GameBoard[31] = null;
        GameBoard[32] = null;
        GameBoard[33] = null;
        GameBoard[34] = null;
        GameBoard[35] = null;
        GameBoard[36] = null;
        GameBoard[37] = null;
        GameBoard[38] = null;
        GameBoard[39] = null;
        GameBoard[40] = null;
        GameBoard[41] = null;
        GameBoard[42] = null;
        GameBoard[43] = null;
        GameBoard[44] = null;
        GameBoard[45] = null;
        GameBoard[46] = null;
        GameBoard[47] = null;
        GameBoard[48] = BPawn1;
        GameBoard[49] = BPawn2;
        GameBoard[50] = BPawn3;
        GameBoard[51] = BPawn4;
        GameBoard[52] = BPawn5;
        GameBoard[53] = BPawn6;
        GameBoard[54] = BPawn7;
        GameBoard[55] = BPawn8;
        GameBoard[56] = BRook1;
        GameBoard[57] = BKnight1;
        GameBoard[58] = BBishop1;
        GameBoard[59] = BKing;
        GameBoard[60] = BQueen;
        GameBoard[61] = BBishop2;
        GameBoard[62] = BKnight2;
        GameBoard[63] = BRook2;
    }

    public static void Move(IPiece creator, bool color, int Direction, int Location, bool Extend)
    {
        MoveTile m = new MoveTile(creator, color, Direction, Location, Extend, false);

        GameBoard[Location] = m;
        if (color)
        {
            MoveTilesWhite.Add(m);
        }
        else
        {
            MoveTilesBlack.Add(m);
        }
    }

    public static void Move(IPiece creator, bool color, int Direction, int Location, bool Extend, bool Initial)
    {
        MoveTile m = new MoveTile(creator, color, Direction, Location, Extend, Initial);
        //MoveTiles.Add(m);
    }

    public static void RemoveMoves(bool color)
    {
        if (!color)
        {
            foreach (MoveTile tile in MoveTilesWhite)
            {
                //Console.WriteLine(GameBoard[tile.Position]);
                GameBoard[tile.Position] = null;
            }

            for (int i = 0; i < MoveTilesWhite.Count(); i++)
            {
                MoveTilesWhite[0] = null;
                MoveTilesWhite.RemoveAt(0);
            }
        }
        else
        {
            foreach (MoveTile tile in MoveTilesBlack)
            {
                //Console.WriteLine(GameBoard[tile.Position]);
                GameBoard[tile.Position] = null;
            }

            for (int i = 0; i < MoveTilesBlack.Count(); i++)
            {
                MoveTilesBlack[0] = null;
                MoveTilesBlack.RemoveAt(0);
            }
        }
    }

    public static void EndGame(bool winner)
    {
        if (Game.P1.Color == winner)
        {
            Game.P1.Wins += 1;
        }
        GameRunning = false;
    }
}
