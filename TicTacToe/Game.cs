using System;
using System.Collections.Generic;

class Game
{
    public Board board { get; set; }
    public List<Player> Players { get; set; }
    public string CurrentMover { get; set; }
    public int CurrentMove { get; set; }
    public int GameStatus { get; set; }

    public Game(int cols, int rows, Player player1, Player player2)
    {
        board = new Board(); // create a new board, the main game board
        Players = new List<Player>(); // create a list of players
        Players.Add(player1); // add first player to player list
        Players.Add(player2); // add second player to player list
        //CurrentPiece = 1;
        GameStatus = 0; // game status, 1 = win or 2 = draw
        startGame();
    }

    public void startGame()
    {
        board.DrawBoard(); // shows the board in the console

        for (int i = 0; i < Players.Count; i++)
        {
            Players[i].Move(board);
            board.DrawBoard();

            if (HasWinner())
            {
                GameStatus = 1;
                break;
            }

            if (IsDraw())
            {
                GameStatus = 2;
                break;
            }

            if (i == 1) // when i == 1 the end of the loop cycle has been reached
                i = -1; // i is set to -1 to reset the loop cycle, i will increase with 1 before the next iteration begins, and therfore start at 0
        }

        if (GameStatus == 1) // if game resulted in a win
            Console.Write("\n" + board.CurrentMover + " wins.");
        else if (GameStatus == 2) // if game resulted in a draw
            Console.Write("\nIt is a draw.");
        Console.ReadLine();
    }

    public bool IsDraw()
    {
        return board.OpenPositions().Length == 0;
    }

    public bool HasWinner()
    {
        return board.HasWinner(board.CurrentMove);
    }


    /*
    public void WaitForChoice()
    {
        ConsoleKey Key;
        do
        {
            Key = Console.ReadKey().Key;
            KeyHandler(Key);
        } while (Key != ConsoleKey.Enter);
    }


    public void KeyHandler(ConsoleKey Key)
    {
        switch (Key)
        {
            case ConsoleKey.RightArrow:
                NavigateRight();
                break;
            case ConsoleKey.LeftArrow:
                NavigateLeft();
                break;
            case ConsoleKey.UpArrow:
                NavigateUp();
                break;
            case ConsoleKey.DownArrow:
                NavigateDown();
                break;
        }
    }

    public void NavigateRight()
    {
        board.NavX = board.NavX + 1 != board.COLS ? board.NavX + 1 : 0;
        board.DrawBoard();
    }

    public void NavigateLeft()
    {
        board.NavX = board.NavX - 1 != -1 ? board.NavX - 1 : board.COLS - 1;
        board.DrawBoard();
    }
    public void NavigateUp()
    {
        board.NavY = board.NavY - 1 != -1 ? board.NavY - 1 : board.ROWS - 1;
        board.DrawBoard();
    }
    public void NavigateDown()
    {
        board.NavY = board.NavY + 1 != board.ROWS ? board.NavY + 1 : 0;
        board.DrawBoard();
    }
*/

}
