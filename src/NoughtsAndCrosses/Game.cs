using System;

namespace NoughtsAndCrosses
{
    public class Game
    {
        private Square[][] _board =
        {
            new Square[3],
            new Square[3],
            new Square[3]
        };

        public void PlayGame()
        {
            Player player = Player.Crosses;

            bool @continue = true;
            while (@continue)
            {
                DisplayBoard();
                @continue = PlayMove(player);
                if (!@continue)
                    return;
                
            }
        }

        private bool PlayMove(Player player)
        {
            throw new NotImplementedException();
        }

        private void DisplayBoard()
        {
            throw new NotImplementedException();
        }
    }
}