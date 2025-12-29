using System;

public class SnakeAndLadder
{
    static Random random = new Random();

    //Board array: index = position, value = destination (snake or ladder)
    static int[] board = new int[101];

    //Method to initialize snakes and ladders
    static void CreateBoard()
    {
        //Ladders
        board[4] = 14;
        board[9] = 31;
        board[20] = 38;
        board[28] = 84;
        board[40] = 59;
        board[71] = 91;

        //Snakes
        board[17] = 7;
        board[54] = 34;
        board[62] = 19;
        board[87] = 24;
        board[99] = 78;
    }

    //Method to roll dice
    static int RollDice()
    {
        return random.Next(1, 7);
    }

    //Method to apply snake or ladder
    static int ApplySnakeOrLadder(int position, out string message)
    {
        message = "";

        if (board[position] != 0)
        {
            if (board[position] > position)
            {
                message = "Ladder";
            }
            else
            {
                message = "Snake";
            }

            position = board[position];
        }

        return position;
    }

    //Method to check win
    static bool CheckWin(int position)
    {
        if (position == 100)
        {
            return true;
        }
        return false;
    }

    //Method to start game
    static void StartGame()
    {
        CreateBoard();

        Console.Write("Enter number of players (2–4): ");
        int playerCount = Convert.ToInt32(Console.ReadLine());

        if (playerCount < 2 || playerCount > 4)
        {
            Console.WriteLine("Invalid number of players.");
            return;
        }

        string[] players = new string[playerCount];
        int[] positions = new int[playerCount];

        for (int i = 0; i < playerCount; i++)
        {
            Console.Write("Enter player name: ");
            players[i] = Console.ReadLine();
            positions[i] = 0;
        }

        bool gameWon = false;

        //Main game loop
        while (!gameWon)
        {
            for (int i = 0; i < playerCount; i++)
            {
                Console.WriteLine($"\n{players[i]}'s turn. Press ENTER to roll dice.");
                Console.ReadLine();

                int dice = RollDice();
                int oldPosition = positions[i];

                Console.WriteLine("Dice rolled: " + dice);

                if (oldPosition + dice > 100)
                {
                    Console.WriteLine("Move exceeds 100. Turn skipped.");
                    continue;
                }

                int newPosition = oldPosition + dice;

                string message;
                newPosition = ApplySnakeOrLadder(newPosition, out message);

                positions[i] = newPosition;

                Console.WriteLine(
                    players[i] + ": " + oldPosition + " → " + newPosition +
                    (message != "" ? " (" + message + ")" : "")
                );

                if (CheckWin(newPosition))
                {
                    Console.WriteLine("\n🏆 " + players[i] + " wins the game!");
                    gameWon = true;
                    break;
                }
            }
        }
    }

    static void Main(string[] args)
    {
        int choice;

        do
        {
            Console.WriteLine("\n=== Snake & Ladder Game ===");
            Console.WriteLine("1. Start Game");
            Console.WriteLine("2. Exit");
            Console.Write("Enter your choice: ");
            choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    StartGame();
                    break;

                case 2:
                    Console.WriteLine("Exiting game...");
                    break;

                default:
                    Console.WriteLine("Invalid choice. Try again.");
                    break;
            }

        } while (choice != 2);
    }
}
