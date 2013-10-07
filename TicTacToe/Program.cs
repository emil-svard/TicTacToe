//************************************************************************************
//
// Programmerare: Didi-Iulia Tudose, Emil Svärd Mårtensson, Murat Demir
// Systemutveckling, Plushögskolan i Malmö
// Lärare: Thomas Frank
//
//************************************************************************************

using System;

class Program
{
    static void Main()
    {
        string menuchoice = MenuChoice("12");

        if (menuchoice == "1")
        {
            string name1 = NameInput("1 ");
            string name2 = NameInput("2 ");
            // create a new game with the first player with name1, and piece representation 1
            // the second player has name2, and piece representation -1
            Game TicTacToe = new Game(3, 3, new Player(name1, 1), new Player(name2, -1));

        }
        else if (menuchoice == "2")
        {
            string name = NameInput("");
            // create a new game with the first player with name and piece 1
            // second player is a computer with the name "Computer", piece -1, and with a SearchDepth of 1
            // meaning the computer can look 1 level down in the minimax tree created in the computers Move method
            Game TicTacToe = new Game(3, 3, new Player(name, 1), new Computer("Computer", -1, 1));
        }
    }

    public static string NameInput(string x)
    {
        string name;
        do
        {
            Console.Clear();
            Console.Write("Player " + x + "name: ");
            name = Console.ReadLine();
        }while(name.Trim() == "");
        return name.Trim();
    }

    public static string MenuChoice(string choices)
    {
        string menuchoice;
        do
        {
            Console.Clear();
            Console.Write("Tic Tac Toe Menu\n_________________________\n\n");
            Console.Write("1. Player vs Player\n");
            Console.Write("2. Player vs Computer\n\n");
            Console.Write("Choice: ");
            menuchoice = Console.ReadLine();
            if (menuchoice.Length != 1 || !choices.Contains(menuchoice))
                continue;
            else
                break;
        } while (true);
        return menuchoice;
    }

}
