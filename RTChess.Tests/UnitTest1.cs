namespace RTChess.Tests;

public class UnitTest1
{
    [Fact]
    public void RookCreated()
    {
        Assert.That(Board.WRook1 != null && Board.WRook2 != null && Board.BRook1 != null && Board.BRook2 != null);
    }

    [Fact]
    public void BishopCreated()
    {
        Assert.That(Board.WBishop1 != null && Board.WBishop2 != null && Board.BBishop1 != null && Board.BBishop2 != null);
    }
}
