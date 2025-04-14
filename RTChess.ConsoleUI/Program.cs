// See https://aka.ms/new-console-template for more information
using RTChess.Logic;
Board board = new Board();
IPiece[] GameBoard = board.GameStart();

for (int i = 0; i < 8; i++)
{
    for (int j = 0; j < 8; j++)
    {
        if(GameBoard[i*8+j]!=null)
        {
            Console.Write(GameBoard[i*8+j].Display);
        }
        else
        {
            Console.Write(" ");
        }
        Console.Write(" ");
    }
    Console.WriteLine();
}