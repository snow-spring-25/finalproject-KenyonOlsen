// See https://aka.ms/new-console-template for more information
using RTChess.Logic;
Console.WriteLine("Hello, World!");
Board board = new Board();
board.GameStart();

for (int i = 0; i < 64; i++)
{
    Console.WriteLine(board.GameBoard[i].Display);
}