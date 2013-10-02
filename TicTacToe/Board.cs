using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Board
{
    public List<string> board = new List<string> { " ", " ", " ", " ", " ", " ", " ", " ", " " };
    static player p = new player();
    

    public void Theboard()
    {

        Console.WriteLine("\n");
        Console.WriteLine(board[0] + "│" + board[1] + "│" + board[2]);
        Console.WriteLine("─┼─┼─");
        Console.WriteLine(board[3] + "│" + board[4] + "│" + board[5]);
        Console.WriteLine("─┼─┼─");
        Console.WriteLine(board[6] + "│" + board[7] + "│" + board[8]);
        Console.WriteLine("────────────────────────────");
        
        

    }
    public void startagain()
    {
        board[0] = " ";
        board[1] = " ";
        board[2] = " ";
        board[3] = " ";
        board[4] = " ";
        board[5] = " ";
        board[6] = " ";
        board[7] = " ";
        board[8] = " ";
        p.turn = false;
        p.TurnWithBot = false;
    }

    public void played()
    {
        Console.BackgroundColor = ConsoleColor.White;
        Console.ForegroundColor = ConsoleColor.Black;
        
        

        Console.Clear();
        Console.WriteLine("Do you wish to go against a Player or a Bot");
        Console.WriteLine("1: Player");
        Console.WriteLine("2: Bot");
        p.against = Console.ReadLine();
        Console.Clear();
        Console.WriteLine("Please enter name of first player");
        p.player1 = Console.ReadLine();
        if (p.against == "1")
        {
            Console.WriteLine("Please enter name of secound player");
            p.player2 = Console.ReadLine();
        }
    

           for (int i = 0; i <= 10; i++)
            {

                if (p.turn == false || p.TurnWithBot == false)
                {

              
                    p.plays1();
                    
                    p.Win();

                    if (i >= 5)
                    {
                        i = 0;
                        p.drawtext();
                    }
                    
                }

                if (p.turn == true & p.against == "1")
                {


                    p.plays2();

                    p.Win(); //doesnt reset all

                    if (i >= 5)
                    {
                        i = 0;
                        p.drawtext();
                    }
                }

                if (p.TurnWithBot == true & p.against == "2")
                {


                    p.bot1();

                    p.Win();

                    if (i >= 5)
                    {
                        i = 0;
                        p.drawtext();
                    }   
         } 
        }
      }
    }
       
    




    

