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

        [Fact]
        public void TestJaggedArrayEx1()
        {
        //Given
            Square[][] sq = {
                new Square[] {new Square(Player.None)},
                new Square[2]
            };
        //When
        //Then
            Assert.Equal(".", sq[0][0].ToString());
        }

        [Fact]
        public void TestJaggedArrayEx2()
        {
            //Given
            Square[][] sq = new Square[3][];
            //When
            sq[0] = new Square[3];
            sq[1] = new Square[2];
            sq[2] = new Square[1];
            //Then
            Assert.Equal(1, sq[2].Length);
        }
    }
}
