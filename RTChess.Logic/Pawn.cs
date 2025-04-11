namespace RTChess.Logic;

public class Pawn : IPiece
{
    char Display = 'P';
    public Pawn(bool color) : base(color, '♙')
    {

    }
}