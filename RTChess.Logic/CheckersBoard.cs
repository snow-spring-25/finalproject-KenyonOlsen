namespace RTChess.Logic;

public class CheckersBoard
{
    public CheckersBoard()
    {
    }
    public static bool GameRunning { get; set; } = true;
    public static List<MoveTile> MoveTiles = new List<MoveTile>();
    public static IPiece Checker1 = new Checker(true, 1);
    public static IPiece Checker2 = new Checker(true, 3);
    public static IPiece Checker3 = new Checker(true, 5);
    public static IPiece Checker4 = new Checker(true, 7);
    public static IPiece Checker5 = new Checker(true, 9);
    public static IPiece Checker6 = new Checker(true, 11);
    public static IPiece Checker7 = new Checker(true, 13);
    public static IPiece Checker8 = new Checker(true, 15);
    public static IPiece Checker9 = new Checker(true, 17);
    public static IPiece Checker10 = new Checker(true, 19);
    public static IPiece Checker11 = new Checker(true, 21);
    public static IPiece Checker12 = new Checker(true, 23);
    public static IPiece Checker13 = new Checker(false, 41);
    public static IPiece Checker14 = new Checker(false, 43);
    public static IPiece Checker15 = new Checker(false, 45);
    public static IPiece Checker16 = new Checker(false, 47);
    public static IPiece Checker17 = new Checker(true, 49);
    public static IPiece Checker18 = new Checker(true, 51);
    public static IPiece Checker19 = new Checker(true, 53);
    public static IPiece Checker20 = new Checker(true, 55);
    public static IPiece Checker21 = new Checker(true, 57);
    public static IPiece Checker22 = new Checker(true, 59);
    public static IPiece Checker23 = new Checker(true, 61);
    public static IPiece Checker24 = new Checker(true, 63);
    //public static IPiece Checker25 = new Checker(false, 48);


    public static IPiece?[] GameBoard =  { null, Checker1, null, Checker2, null, Checker3, null, Checker4,
        Checker5, null, Checker6, null, Checker7, null, Checker8, null,
        null, Checker9, null, Checker10, null, Checker11, null, Checker12 ,
        null, null, null, null, null, null, null, null ,
        null, null, null, null, null, null, null, null ,
        Checker13, null, Checker14, null, Checker15, null, Checker16 , null,
        null, Checker17, null, Checker18, null, Checker19, null, Checker20,
        Checker21, null, Checker22, null, Checker23, null, Checker24 ,null};

    public static void Move(IPiece creator, bool color, int Direction, int Location, bool Extend)
    {
        MoveTile m = new MoveTile(creator, color, Direction, Location, Extend, false);

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
            //Console.WriteLine(GameBoard[tile.Position]);
            GameBoard[tile.Position] = null;
        }

        for (int i = 0; i < MoveTiles.Count(); i++)
        {
            MoveTiles[0] = null;
            MoveTiles.RemoveAt(0);
        }
    }

    public static void EndGame(bool Winner)
    {
        GameRunning = false;
    }
}
