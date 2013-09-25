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

        player p = new player();


        
        List<string> board2 = new List<string> { "1", "2", "3", "4", "5", "6", "7", "8", "9" };

        Console.WriteLine("My Tic Tac Toe");
        Console.WriteLine("\n");
        Console.WriteLine("Press any key to continue");
        Console.ReadLine();
        Console.Clear();
        Console.WriteLine("Please enter name of first player");
        p.player1 = Console.ReadLine();
        Console.WriteLine("Please enter name of secound player");
        p.player2 = Console.ReadLine();



        if (p.turn == false)
        {

            p.plays2();


            

        }

        p.turn = true;
        if (p.turn == true)
        {
            
            p.plays1();

            
            
        }
        p.turn = false;

      }

     }
       
    




    

