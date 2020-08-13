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
        public void TestStructDefaultValueWithJaggedArray()
        {
            //Given
            Square[][] sq = {
                new Square[1],
                new Square[1]
            };
            //When
            //Then
            foreach (var s in sq)
            {
                Assert.Equal(".", s[0].ToString());
            }
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

        [Fact]
        public void TestMultidimensionnalArray()
        {
        //Given
            Square[,] sq = new Square[2, 2];
        //Then
            Assert.Equal(".", sq[0, 0].ToString());
            Assert.Equal(".", sq[0, 1].ToString());
        }
    }
}
