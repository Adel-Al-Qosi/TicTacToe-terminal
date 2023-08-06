using System;

namespace TicTacToe
{
    class Program
    {
        static int player = 1;
        static bool gameOver = false;
        static string[,] matrix =
        {

            { "1", "2", "3" },
            { "4", "5", "6" },
            { "7", "8", "9" }
        };

        static void Main(string[] args)
        {

            while (!gameOver)
            {
                ShowBoard();
                bool validInput = Play();

                if (CheckWin())
                {
                    Console.WriteLine("Player {0} has won!", player);
                    gameOver = true;
                    Console.ReadKey();
                }
                else if (CheckDraw())
                {
                    Console.WriteLine("It's a draw!");
                    gameOver = true;
                    Console.ReadKey();
                }
                
                if (validInput) SwitchPlayers();
                Console.Clear();
            }

            Reset();
        }

        public static void SwitchPlayers()
        {
            player = (player == 1) ? 2 : 1;
        }


        public static bool CheckWin()
        {
            for (int i = 0; i < 3; i++)
            {
                if (matrix[i, 0] == matrix[i, 1] && matrix[i, 1] == matrix[i, 2])
                    return true;
            }

            for (int i = 0; i < 3; i++)
            {
                if (matrix[0, i] == matrix[1, i] && matrix[1, i] == matrix[2, i])
                    return true;
            }

            if (matrix[0, 0] == matrix[1, 1] && matrix[1, 1] == matrix[2, 2])
                return true;
            if (matrix[0, 2] == matrix[1, 1] && matrix[1, 1] == matrix[2, 0])
                return true;

            return false;
        }



        public static bool CheckDraw()
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (int.TryParse(matrix[i, j], out int result))
                    {
                        return false;
                    }
                }
            }

            return true;
        }

        public static void ShowBoard()
        {
            Console.WriteLine("     |     |     ");
            Console.WriteLine("  {0}  |  {1}  |  {2}  ", matrix[0, 0], matrix[0, 1], matrix[0, 2]);
            Console.WriteLine("_____|_____|_____");
            Console.WriteLine("     |     |     ");
            Console.WriteLine("  {0}  |  {1}  |  {2}  ", matrix[1, 0], matrix[1, 1], matrix[1, 2]);
            Console.WriteLine("_____|_____|_____");
            Console.WriteLine("     |     |     ");
            Console.WriteLine("  {0}  |  {1}  |  {2}  ", matrix[2, 0], matrix[2, 1], matrix[2, 2]);
            Console.WriteLine("     |     |     ");
            Console.WriteLine();
            Console.WriteLine();
        }

        public static void Reset()
        {
            Console.WriteLine("Press any key to play again ...");
            Console.ReadKey();
            int k = 1;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = k.ToString();
                    k++;
                }
            }
            player = 1;
            gameOver = false;
            Console.Clear();
            Main(null);
        }

        public static bool Play()
        {
            Console.Write($"Player {player} turn. ");
            Console.Write("Select a number: ");
            string playerSelected = Console.ReadLine();

            switch (playerSelected)
            {
                case "1":
                    if (matrix[0, 0] != "X" && matrix[0, 0] != "O")
                    {
                        matrix[0, 0] = (player == 1) ? "X" : "O";
                        return true;
                    }
                        
                    else
                    {
                        Console.WriteLine("Cell already occupied! Try again.");
                        Console.ReadKey();
                    }
                    break;
                case "2":
                    if (matrix[0, 1] != "X" && matrix[0, 1] != "O")
                    {
                        matrix[0, 1] = (player == 1) ? "X" : "O";
                        return true;
                    }
                    else
                    {
                        Console.WriteLine("Cell already occupied! Try again.");
                        Console.ReadKey();
                    }
                    break;
                case "3":
                    if (matrix[0, 2] != "X" && matrix[0, 2] != "O")
                    {
                        matrix[0, 2] = (player == 1) ? "X" : "O";
                        return true;
                    }
                    else
                    {
                        Console.WriteLine("Cell already occupied! Try again.");
                        Console.ReadKey();
                    }
                    break;
                case "4":
                    if (matrix[1, 0] != "X" && matrix[1, 0] != "O")
                    {
                        matrix[1, 0] = (player == 1) ? "X" : "O";
                        return true;
                    }
                    else
                    {
                        Console.WriteLine("Cell already occupied! Try again.");
                        Console.ReadKey();
                    }
                    break;
                case "5":
                    if (matrix[1, 1] != "X" && matrix[1, 1] != "O")
                    {
                        matrix[1, 1] = (player == 1) ? "X" : "O";
                        return true;
                    }
                    else
                    {
                        Console.WriteLine("Cell already occupied! Try again.");
                        Console.ReadKey();
                    }
                    break;
                case "6":
                    if (matrix[1, 2] != "X" && matrix[1, 2] != "O")
                    {
                        matrix[1, 2] = (player == 1) ? "X" : "O";
                        return true;
                    }
                    else
                    {
                        Console.WriteLine("Cell already occupied! Try again.");
                        Console.ReadKey();
                    }
                    break;
                case "7":
                    if (matrix[2, 0] != "X" && matrix[2, 0] != "O")
                    {
                        matrix[2, 0] = (player == 1) ? "X" : "O";
                        return true;
                    }
                    else
                    {
                        Console.WriteLine("Cell already occupied! Try again.");
                        Console.ReadKey();
                    }
                    break;
                case "8":
                    if (matrix[2, 1] != "X" && matrix[2, 1] != "O")
                    {
                        matrix[2, 1] = (player == 1) ? "X" : "O";
                        return true;
                    }
                    else
                    {
                        Console.WriteLine("Cell already occupied! Try again.");
                        Console.ReadKey();
                    }
                    break;
                case "9":
                    if (matrix[2, 2] != "X" && matrix[2, 2] != "O")
                    {
                        matrix[2, 2] = (player == 1) ? "X" : "O";
                        return true;
                    }
                    else
                    {
                        Console.WriteLine("Cell already occupied! Try again.");
                        Console.ReadKey();
                    }
                    break;
                default:
                    Console.WriteLine("Not a valid input. Please try again.");
                    Console.ReadKey();
                    break;
            }
            return false;
        }
    }
}
