namespace RTChess.Logic;

public class CheckersBoard
{
    public CheckersBoard()
    {
    }
    public static bool GameRunning { get; set; } = true;
    public static List<CheckersMoveTile> CheckersMoveTiles = new List<CheckersMoveTile>();
    public static IPiece Checker1 = new Checker(true, 0);
    public static IPiece Checker2 = new Checker(true, 2);
    public static IPiece Checker3 = new Checker(true, 4);
    public static IPiece Checker4 = new Checker(true, 6);
    public static IPiece Checker5 = new Checker(true, 9);
    public static IPiece Checker6 = new Checker(true, 11);
    public static IPiece Checker7 = new Checker(true, 13);
    public static IPiece Checker8 = new Checker(true, 15);
    public static IPiece Checker9 = new Checker(true, 16);
    public static IPiece Checker10 = new Checker(true, 18);
    public static IPiece Checker11 = new Checker(true, 20);
    public static IPiece Checker12 = new Checker(true, 22);
    public static IPiece Checker13 = new Checker(false, 41);
    public static IPiece Checker14 = new Checker(false, 43);
    public static IPiece Checker15 = new Checker(false, 45);
    public static IPiece Checker16 = new Checker(false, 47);
    public static IPiece Checker17 = new Checker(false, 48);
    public static IPiece Checker18 = new Checker(false, 50);
    public static IPiece Checker19 = new Checker(false, 52);
    public static IPiece Checker20 = new Checker(false, 54);
    public static IPiece Checker21 = new Checker(false, 57);
    public static IPiece Checker22 = new Checker(false, 59);
    public static IPiece Checker23 = new Checker(false, 61);
    public static IPiece Checker24 = new Checker(false, 63);
    //public static IPiece Checker25 = new Checker(false, 48);


    public static IPiece?[] GameBoard =  {Checker1, null, Checker2, null, Checker3, null, Checker4, null,
        null, Checker5, null, Checker6, null, Checker7, null, Checker8,
        Checker9, null, Checker10, null, Checker11, null, Checker12 , null,
        null, null, null, null, null, null, null, null ,
        null, null, null, null, null, null, null, null ,
        null, Checker13, null, Checker14, null, Checker15, null, Checker16 ,
        Checker17, null, Checker18, null, Checker19, null, Checker20,null,
        null, Checker21, null, Checker22, null, Checker23, null, Checker24 };

    public static void Move(IPiece creator, bool color, int Direction, int Location, bool Extend)
    {
        CheckersMoveTile m = new CheckersMoveTile(creator, color, Direction, Location, Extend, false);

        GameBoard[Location] = m;
        CheckersMoveTiles.Add(m);

    }

    public static void Move(IPiece creator, bool color, int Direction, int Location, bool Extend, bool Initial)
    {
        CheckersMoveTile m = new CheckersMoveTile(creator, color, Direction, Location, Extend, Initial);
        //MoveTiles.Add(m);
    }

    public static void RemoveMoves()
    {
        foreach (CheckersMoveTile tile in CheckersMoveTiles)
        {
            //Console.WriteLine(GameBoard[tile.Position]);
            GameBoard[tile.Position] = null;
        }

        for (int i = 0; i < CheckersMoveTiles.Count(); i++)
        {
            CheckersMoveTiles[0] = null;
            CheckersMoveTiles.RemoveAt(0);
        }
    }

    public static void EndGame(bool Winner)
    {
        GameRunning = false;
    }
}
