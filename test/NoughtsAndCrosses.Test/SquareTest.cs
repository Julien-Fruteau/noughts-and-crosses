using System;
using Xunit;

namespace NoughtsAndCrosses.Test
{
    public class SquareTest
    {
        [Fact]
        public void TestPositiveConstructor()
        {
            Square sq = new Square(Player.Noughts);
            Assert.Equal("O", sq.ToString());
        }

    }
}
