using System;

class Program
{
    static char[,] board = {
        {' ', ' ', ' '},
        {' ', ' ', ' '},
        {' ', ' ', ' '}
    };

    static char currentPlayer = 'X';

    static void Main()
    {
        bool gameOver = false;

        do
        {
            PrintBoard();
            MakeMove();

            if (CheckForWinner() || CheckForTie())
            {
                gameOver = true;
                PrintBoard();
                if (CheckForWinner())
                {
                    Console.WriteLine($"Jogador {currentPlayer} venceu!");
                }
                else
                {
                    Console.WriteLine("Deu velha!");
                }
            }

            SwitchPlayer();
        } while (!gameOver);
    }

    static void PrintBoard()
    {
        Console.WriteLine("  0 1 2");
        for (int i = 0; i < 3; i++)
        {
            Console.Write(i);
            for (int j = 0; j < 3; j++)
            {
                Console.Write($" {board[i, j]}");
            }
            Console.WriteLine();
        }
    }

    static void MakeMove()
    {
        bool validMove = false;
        do
        {
            Console.Write($"Jogador {currentPlayer}, informe a linha e coluna: ");
            string[] input = Console.ReadLine().Split(' ');

            if (input.Length == 2 && int.TryParse(input[0], out int row) && int.TryParse(input[1], out int col)
                && row >= 0 && row < 3 && col >= 0 && col < 3 && board[row, col] == ' ')
            {
                board[row, col] = currentPlayer;
                validMove = true;
            }
            else
            {
                Console.WriteLine("Movimento não permitido. Tente outro.");
            }
        } while (!validMove);
    }

    static bool CheckForWinner()
    {
        for (int i = 0; i < 3; i++)
        {
            if (board[i, 0] == currentPlayer && board[i, 1] == currentPlayer && board[i, 2] == currentPlayer)
            {
                return true; 
            }

            if (board[0, i] == currentPlayer && board[1, i] == currentPlayer && board[2, i] == currentPlayer)
            {
                return true; 
            }
        }

        if (board[0, 0] == currentPlayer && board[1, 1] == currentPlayer && board[2, 2] == currentPlayer)
        {
            return true; 
        }

        if (board[0, 2] == currentPlayer && board[1, 1] == currentPlayer && board[2, 0] == currentPlayer)
        {
            return true; 
        }

        return false;
    }

    static bool CheckForTie()
    {
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                if (board[i, j] == ' ')
                {
                    return false; 
                }
            }
        }
        return true; 
    }

    static void SwitchPlayer()
    {
        currentPlayer = (currentPlayer == 'X') ? 'O' : 'X';
    }
}
