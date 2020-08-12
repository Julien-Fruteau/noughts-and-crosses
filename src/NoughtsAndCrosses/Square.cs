using System;

namespace NoughtsAndCrosses
{
    public enum Player {None = 0, Noughts, Crosses}

    public struct Square
    {
        public Player Owner {get;}
        public Square(Player owner)
        {
            this.Owner = owner;
        }

        public override string ToString()
        {
            switch (Owner)
            {
                case Player.None:
                    return ".";
                case Player.Noughts:
                    return "O";
                case Player.Crosses:
                    return "X";
                default:
                    throw new Exception("Invalid state");
            }
        }
    }
}