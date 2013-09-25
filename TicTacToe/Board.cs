using System;
using System.Collections.Generic;

class Board
{
    public string[,] Field { get; set; }
    public List<Player> Players { get; set; }

    public Board()
    {
        Field = new string[3, 3];
    }

    public void place(int x, int y)
    {
        Field[x - 1, y - 1] = "X";
    }

    public void drawBoard()
    {
        Console.Clear();
        Console.Write("\n-------\n");

        for (int i = 0; i < Field.GetLength(0); i++)
        {
            for (int j = 0; j < Field.GetLength(1); j++)
            {
                if (j == 0)
                {
                    Console.Write("|");
                }
                Console.Write(Field[i, j] + " |");
            }
            Console.Write("\n-------\n");
        }
    }
}

