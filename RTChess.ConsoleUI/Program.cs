// See https://aka.ms/new-console-template for more information
using RTChess.Logic;

void RefreshBoard()
{
    Board.GameBoard[0].Move();
    Console.WriteLine();
    Console.WriteLine();
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
