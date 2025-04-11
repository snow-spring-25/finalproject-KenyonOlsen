// See https://aka.ms/new-console-template for more information
using RTChess.Logic;
Board board = new Board();
IPiece[] GameBoard = board.GameStart();

for (int i = 0; i < 2; i++)
{
    for (int j = 0; j < 8; j++)
    {
        //Console.WriteLine(GameBoard[i]);
        Console.Write(GameBoard[i*8+j].Display);
        Console.Write(" ");
    }
    Console.WriteLine();
}