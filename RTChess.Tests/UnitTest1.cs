namespace RTChess.Tests;
using RTChess.Logic;
public class UnitTest1
{
    [Fact]
    public void RookCreated()
    {
        Assert.True(Board.WRook1 != null && Board.WRook2 != null && Board.BRook1 != null && Board.BRook2 != null);
    }

    [Fact]
    public void BishopCreated()
    {
        Assert.True(Board.WBishop1 != null && Board.WBishop2 != null && Board.BBishop1 != null && Board.BBishop2 != null);
    }

    [Fact]
    public void PositionMatches()
    {
        for (int i = 0; i < 64; i++)
        {
            if (Board.GameBoard[i] != null)
            {
                Assert.True(Board.GameBoard[i].Position == i);
            }
        }
    }

    [Fact]
    public void MoveTilePositionMatchesPreMove()
    {
        bool flag = true;
        Board.GameBoard[7].Move();
        for (int i = 0; i < 64; i++)
        {
            if (Board.GameBoard[i] != null)
            {
                if(Board.GameBoard[i].Position != i)
                {
                    flag=false;
                }
            }
        }
        Assert.True(flag);
    }

    [Fact]
    public void MoveTilePositionMatchesPostMove()
    {
        bool flag = true;
        Board.GameBoard[0].Move();
        Board.GameBoard[8].Move();
        Board.GameBoard[8].Move();
        Board.GameBoard[16].Move();
        for (int i = 0; i < 64; i++)
        {
            if (Board.GameBoard[i] != null)
            {
                if(Board.GameBoard[i].Position != i)
                {
                    flag=false;
                }
            }
        }
        Assert.True(flag);
    }
}
