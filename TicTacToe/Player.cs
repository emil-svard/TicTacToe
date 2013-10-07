//************************************************************************************
//
// Programmerare: Didi-Iulia Tudose, Emil Svärd Mårtensson, Murat Demir
// Systemutveckling, Plushögskolan i Malmö
// Lärare: Thomas Frank
//
//************************************************************************************

using System;

class Player
{
    public string Name { get; set; }
    public int Piece { get; set; }

    public Player(string name, int piece)
    {
        this.Name = name;
        this.Piece = piece;
    }

    // is virtual because the computer class inherits from the player class and has a Move method as well
    virtual public void Move(Board board)
    {
        string digits = "012345678";
        string i;
        int inum = 0;
        bool success = false;
        do
        {
            Console.Clear();
            board.DrawBoard();
            Console.Write("\n" + this.Name + (this.Name.ToLower()[this.Name.Length-1]=='s' ? "'" : "'s") + " turn\nPosition (0-8): ");
            i = Console.ReadLine();
            if (i.Length != 1 || !digits.Contains(i))
                continue;
            success = int.TryParse(i, out inum);
        } while (!success || !board.IsValidSquare(inum));
        if (success)
            board.Place(inum, Piece, this.Name);
    }
}

