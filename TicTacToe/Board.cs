using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Board
{

    public string turn = "player1";
    public void board()
    {
        Console.BackgroundColor = ConsoleColor.White;
        Console.ForegroundColor = ConsoleColor.Black;
        List<string> board = new List<string> { "1", "2", "3", "4", "5", "6", "7", "8", "9" }; //useless atm
        player p = new player();
        Console.Clear();
        Console.WriteLine("Please enter name of first player");
        p.player1 = Console.ReadLine();
        Console.WriteLine("Please enter name of secound player");
        p.player2 = Console.ReadLine();
        

            for (int i = 0; i <= 9; i++)
            {

                if (p.turn == false)
                {

                    p.plays1();
                    p.Win();
                    if (p.playagain == true)
                    {
                        p.startagain();
                        i = 0;
                    }
                    if (i >= 4)
                    {
                        Console.WriteLine("ITS A DRAW");
                        Environment.Exit(0);   
                    }
                }

                if (p.turn == true)
                {

                    p.plays2();
                    p.Win2();
                    if (p.playagain == true)
                    {
                        p.startagain();
                        i = 0;
                    }
                    if (i >= 4)
                    {
                        Console.WriteLine("ITS A DRAW");
                        Environment.Exit(0);
                    }
           }    
        }
      }
    }
       
    




    

