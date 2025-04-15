// See https://aka.ms/new-console-template for more information
using RTChess.Logic;
//Board board = new Board();
//IPiece[] GameBoard = Board.GameStart();
Console.WriteLine();
Console.WriteLine();
Board.Move(true, 0, 20);
Board.Move(true, 1, 20);
Board.Move(true, 2, 20);
Board.Move(true, 3, 20);
void RefreshBoard()
{
    for (int i = 0; i < 8; i++)
    {
        for (int j = 0; j < 8; j++)
        {
            if (Board.GameBoard[i * 8 + j] != null)
            {
                Console.Write(Board.GameBoard[i * 8 + j].Display);
            }
            else
            {
                Console.Write(" ");
            }
            Console.Write(" ");
        }
        Console.WriteLine();
    }
    Thread.Sleep(3000);
    RefreshBoard();
}
RefreshBoard();
