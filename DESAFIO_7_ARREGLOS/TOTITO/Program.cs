using System;

class TicTacToe
{

    private static char[,] board = new char[3, 3] {
        { ' ', ' ', ' ' },
        { ' ', ' ', ' ' },
        { ' ', ' ', ' ' }
    };

    private static char currentPlayer = 'X';

    public static void Main(string[] args)
    {
        while (true)
        {
            DisplayBoard();

            Console.Write("Jugador {0}, ingrese su coordenada X (0-2): ", currentPlayer);
            int x = int.Parse(Console.ReadLine());

            Console.Write("Jugador {0}, ingrese su coordenada Y (0-2): ", currentPlayer);
            int y = int.Parse(Console.ReadLine());

            if (!IsValidMove(x, y))
            {
                Console.WriteLine("Movimiento inválido. Intente de nuevo.");
                continue;
            }

            MakeMove(x, y);

            if (CheckWin())
            {
                DisplayBoard();
                Console.WriteLine("¡El jugador {0} ha ganado!", currentPlayer);
                break;
            }

            if (IsBoardFull())
            {
                DisplayBoard();
                Console.WriteLine("Empate!");
                break;
            }

            SwitchPlayer();
        }
    }

    private static void DisplayBoard()
    {
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                Console.Write(board[i, j] + " ");
            }
            Console.WriteLine();
        }
    }

    private static bool IsValidMove(int x, int y)
    {
        return x >= 0 && x < 3 && y >= 0 && y < 3 && board[x, y] == ' ';
    }

    private static void MakeMove(int x, int y)
    {
        board[x, y] = currentPlayer;
    }

    private static bool CheckWin()
    {
        // Check rows
        for (int i = 0; i < 3; i++)
        {
            if (board[i, 0] == currentPlayer && board[i, 1] == currentPlayer && board[i, 2] == currentPlayer)
            {
                return true;
            }
        }

        // Check columns
        for (int i = 0; i < 3; i++)
        {
            if (board[0, i] == currentPlayer && board[1, i] == currentPlayer && board[2, i] == currentPlayer)
            {
                return true;
            }
        }

        // Check diagonals
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

    private static bool IsBoardFull()
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

    private static void SwitchPlayer()
    {
        if (currentPlayer == 'X')
        {
            currentPlayer = 'O';
        }
        else
        {
            currentPlayer = 'X';
        }
    }
}
