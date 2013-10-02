using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Board
{
    public List<string> board = new List<string> { " ", " ", " ", " ", " ", " ", " ", " ", " " };
    public string turn = "player1";
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

    public void played()
    {
        Console.BackgroundColor = ConsoleColor.White;
        Console.ForegroundColor = ConsoleColor.Black;
        
        

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
                        Console.WriteLine("Do you wish to play again Y/N?");
                        string svar = Console.ReadLine();
                        if (svar == "Y")
                        {
                            p.startagain();
                            i = 0;
                        }
                        else
                        {

                            Console.WriteLine("Thanks for playing!");
                            Environment.Exit(0);

                        }
                    }
                }

                if (p.turn == true)
                {

           
                    p.plays2();
                    
                    p.Win();
                    
                    if (p.playagain == true)
                    {
                        p.startagain();
                        i = 0;
                    }
                    if (i >= 4)
                    {
                        Console.WriteLine("ITS A DRAW");
                        Console.WriteLine("Do you wish to play again Y/N?");
                        string svar = Console.ReadLine();
                        if (svar == "Y")
                        {
                            p.startagain();
                            i = 0;
                        }
                        else
                        {
                            
                                Console.WriteLine("Thanks for playing!");
                                Environment.Exit(0);
                            
                        }
                    }
           }    
        }
      }
    }
       
    




    

