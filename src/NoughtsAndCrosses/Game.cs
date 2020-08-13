using System;

namespace NoughtsAndCrosses
{
    public class Game
    {
        private Square[,] _board = new Square[3, 3];

        public void PlayGame()
        {
            Player player = Player.Crosses;

            bool @continue = true;      // @ distinguishes a variable name from a C# keyword
            while (@continue)
            {
                DisplayBoard();
                @continue = PlayMove(player);
                if (!@continue)
                    return;
                player = 3 - player;    // swaps between X and 0
            }
        }

        private bool PlayMove(Player player)
        {
            Console.WriteLine("Invalid inputs quits game");
            Console.Write($"{player}: Enter row comma column, eg. 3,3 > ");
            string input = Console.ReadLine();
            string[] parts = input.Split(',');
            if (parts.Length != 2)
                return false;
            int.TryParse(parts[0], out int row);
            int.TryParse(parts[1], out int column);

            if (row < 1 || row > 3 || column < 1 || column > 3)
                return false;

            if (_board[row - 1, column -1].Owner != Player.None)
            {
                Console.WriteLine("Square is already occupied");
                return false;
            }

            _board[row -1, column -1] = new Square(player);
            return true;
        }

        private void DisplayBoard()
        {
            for (int i = 0; i < 3; i++)
            {
                string line = "";
                for (int j = 0; j < 3; j++)
                    line += " " + _board[i, j];
                Console.WriteLine(line);
            }
        }
    }
}