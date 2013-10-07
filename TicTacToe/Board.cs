//************************************************************************************
//
// Programmerare: Didi-Iulia Tudose, Emil Svärd Mårtensson, Murat Demir
// Systemutveckling, Plushögskolan i Malmö
// Lärare: Thomas Frank
//
//************************************************************************************

using System;
using System.Collections.Generic;

public struct Point
{
    public int X, Y;
}

class Board : ICloneable // experiment with cloning the board, which right now, is done manually
{
    public int[,] board { get; set; }
    public int ROWS = 3;
    public int COLS = 3;
    public int Winner { get; set; }
    public int CurrentMove { get; set; }
    public string CurrentMover { get; set; }
    public static Dictionary<int, string> Pieces = new Dictionary<int, string>() { { 0, " " }, { 1, "X" }, { -1, "O" } };

    public Board()
    {
        board = new int[ROWS, COLS];

        for (int i = 0; i < board.GetLength(0); i++)
        {
            for (int j = 0; j < board.GetLength(1); j++)
            {
                board[i, j] = 0;
            }
        }
    }

    // overloaded constructor for when the computer creates new boards based on already existing ones
    public Board(int[,] gameState)
        : this()
    {
        for (int i = 0; i <= gameState.GetUpperBound(0); i++)
            for (int j = 0; j <= gameState.GetUpperBound(1); j++)
            {
                this.board[i, j] = gameState[i, j];
            }
    }

/*
    public void Place(int x, int y, Player player)
    {
        board[x - 1, y - 1] = player.Piece;
    }
*/

    public void Place(int position, int piece, string mover)
    {
        Point p = GetPoint(position);
        board[p.Y, p.X] = piece;
        CurrentMover = mover; // name of the player that places the piece
        CurrentMove = position; // the position to place the piece
    }


    // checks if square at position is empty (an open position). returns true if empty
    public bool IsValidSquare(int position)
    {
        Point p = GetPoint(position);
        return board[p.Y, p.X] == 0;
    }

    // checks all relevant squares on the board for a win
    public bool HasWinner(int position)
    {
        Point p = GetPoint(position);
        return WinRow(p.Y) || WinColumn(p.X) || WinDiagonal(p.Y, p.X) || WinAntiDiagonal(p.Y, p.X);
    }

    public bool WinRow(int row)
    {
        bool win = false;
        int sum = 0;
        for (int i = 0; i < COLS; i++)
        {
            sum += board[row, i];
        }
        win = Math.Abs(sum) == 3 ? true : false; // if the sum is either positive or negative 3, then we have a winner
        if (win) Winner = sum/3;
        return win;
    }

    public bool WinColumn(int column)
    {
        bool win = false;
        int sum = 0;
        for (int i = 0; i < ROWS; i++)
        {
            sum += board[i, column];
        }
        win = Math.Abs(sum) == 3 ? true : false; // if the sum is either positive or negative 3, then we have a winner
        if (win) Winner = sum/3;
        return win;
    }

    public bool WinDiagonal(int row, int column)
    {
        bool win = false;
        int sum = 0;
        // If the piece to be placed, has equal y and x positions, then we're on the diagonal 
        if (row == column)
        {
            for (int i = 0; i < ROWS; i++)
            {
                sum += board[i, i];
            }
            win = Math.Abs(sum) == 3 ? true : false; // if the sum is either positive or negative 3, then we have a winner
        }
        if (win) Winner = sum/3;
        return win;
    }

    public bool WinAntiDiagonal(int row, int column)
    {
        bool win = false;
        int sum = 0;
        // If the piece's (to be placed) y and x position+1 equals the number of rows on the board (given that it's square), then we're on the anti-diagonal 
        if (row + column + 1 == ROWS)
        {
            for (int i = 0; i < ROWS; i++)
            {
                sum += board[i, (COLS - 1) - i];
            }
            win = Math.Abs(sum) == 3 ? true : false; // if the sum is either positive or negative 3, then we have a winner
        }
        if (win) Winner = sum/3;
        return win;
    }

    // gets all open positions (empty squares) (0-8) and puts them in a List of integers
    public int[] OpenPositions()
    {
        List<int> positions = new List<int>();
        for (int i = 0; i < board.Length; i++)
        {
            if (IsValidSquare(i))
                positions.Add(i);
        }
        return positions.ToArray();
    }

    // checks if the position integer is a number between 0 and 8. returns true if it is
    public bool WithinBounds(int position)
    {
        if (position >= 0 && position <= 8)
            return true;
        else
            return false;
    }

    // returns the X and Y coordinates (column and row respectively) from a specified position (0-8). Point is a custom struct in this case
    public Point GetPoint(int position)
    {
        Point p = new Point();
        p.X = position % ROWS;
        p.Y = position / COLS;
        return p;
    }

    // returns the integer representation of the piece, at the specified row and column
    public int GetPieceAtPoint(int row, int col)
    {
        return this.board[row, col];
    }

    // draws the board - grid and pieces
    public void DrawBoard()
    {
        Console.Clear();
        Console.Write("┌");
        for (int i = 0; i < COLS - 1; i++)
            Console.Write("───┬");
        Console.Write("───┐\n");

        for (int i = 0; i < ROWS; i++)
        {
            Console.Write("│");
            for (int j = 0; j < COLS; j++)
            {
                Print(" " + Pieces[board[i, j]] + " │");
            }
            Console.Write("\n");

            if (i + 1 != ROWS)
            {
                Console.Write("├");
                for (int j = 0; j < COLS - 1; j++)
                {
                    Console.Write("───┼");
                }
                Console.Write("───┤\n");
            }
            else
            {
                Console.Write("└");
                for (int j = 0; j < COLS - 1; j++)
                {
                    Console.Write("───┴");
                }
                Console.Write("───┘");
            }
        }
    }

    public static void Print(string text, ConsoleColor backgroundcolor = ConsoleColor.Black)
    {
        Console.BackgroundColor = backgroundcolor;
        Console.Write(text);
        Console.ResetColor();
    }


    public object Clone() // is not used right now, because the board is copied manually
    {
        Board b = new Board(this.board);
        return b;
    }
}

