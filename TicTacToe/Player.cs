using System;


class Player
{
    public string Piece { get; set; }

    public Player(string piece)
    {
        this.Piece = piece;
    }


    public int inputX()
    {
        Console.Write("kolumn: ");
        string x = Console.ReadLine();
        int xnum;
        bool success = int.TryParse(x, out xnum);
        if (success)
        {
            return xnum;
        }
        else
            return -1;
    }

    public int inputY()
    {
        Console.Write("rad: ");
        string x = Console.ReadLine();
        int xnum;
        bool success = int.TryParse(x, out xnum);
        if (success)
        {
            return xnum;
        }
        else
            return -1;
    }
}

