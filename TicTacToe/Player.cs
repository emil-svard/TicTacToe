using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class player
{

    public string player1, player2, pos, svar, against, bot = "Bot";
    public bool turn, TurnWithBot;
    
    public bool legit, legit2, legit3;
    static Board b = new Board();
    

    public void drawtext() 
    {
        Console.Clear();
        b.Theboard();
        Console.WriteLine("ITS A DRAW");
        Console.WriteLine("Do you wish to play again Y/N?");
        svar = Console.ReadLine();
        if (svar == "Y")
        {
            b.startagain();
        }
        else
        {

            Credit();
            Environment.Exit(0);

        }

    }

    public void WinnerText()
    {

        if (turn == true)
        {
            Console.Clear();
            b.Theboard();
            Console.WriteLine("You win " + bot);
        }
        if (turn == false)
        {
            Console.Clear();
            b.Theboard();
            Console.WriteLine("You win " + player2);
        }
        if (TurnWithBot == false)
        {
            Console.Clear();
            b.Theboard();
            Console.WriteLine("Cant believe you lost to this horrible " + bot);
        }
        
        Console.WriteLine("Do you want to play again? Y/N");
        pos = Console.ReadLine();
        if (pos == "Y")
        {
            b.startagain();
        }
        else
        {
            Credit();
            Environment.Exit(0);
        }

    }
    public void Credit()
    {
        Console.WriteLine("Thanks for playing!");
        Console.WriteLine("Good Bye!");
     

    }
    public void isit()
    {
        foreach (var x in b.board)
        {
            if (x == "X")
                {
                 
                break;
                } 
        }
    }

    
    public void Win()
    {
        //funkar inte med board[0] == board[1] && board[1] == board[2] för att man vinner i start alla boards == " ";
        if (b.board[0] == "X" & b.board[1] == "X" & b.board[2] == "X")
            WinnerText();
        if (b.board[3] == "X" & b.board[4] == "X" & b.board[5] == "X")
            WinnerText();
        if (b.board[6] == "X" & b.board[7] == "X" & b.board[8] == "X")
            WinnerText();
        if (b.board[0] == "X" & b.board[3] == "X" & b.board[6] == "X")
            WinnerText();
        if (b.board[0] == "X" & b.board[4] == "X" & b.board[8] == "X")
            WinnerText();
        if (b.board[2] == "X" & b.board[4] == "X" & b.board[6] == "X")
            WinnerText();
        if (b.board[1] == "X" & b.board[4] == "X" & b.board[7] == "X")
            WinnerText();
        if (b.board[2] == "X" & b.board[5] == "X" & b.board[8] == "X")
            WinnerText();

        // player 2 / bot
        if (b.board[0] == "O" & b.board[1] == "O" & b.board[2] == "O")
            WinnerText();
        if (b.board[3] == "O" & b.board[4] == "O" & b.board[5] == "O")
            WinnerText();
        if (b.board[6] == "O" & b.board[7] == "O" & b.board[8] == "O")
            WinnerText();
        if (b.board[0] == "O" & b.board[3] == "O" & b.board[6] == "O")
            WinnerText();
        if (b.board[0] == "O" & b.board[4] == "O" & b.board[8] == "O")
            WinnerText();
        if (b.board[2] == "O" & b.board[4] == "O" & b.board[6] == "O")
            WinnerText();
        if (b.board[1] == "O" & b.board[4] == "O" & b.board[7] == "O")
            WinnerText();
        if (b.board[2] == "O" & b.board[5] == "O" & b.board[8] == "O")
            WinnerText();
    }

    

    public void bot1()
    {
        {


            

            legit3 = false;
            do
            {
                Console.Clear();
                b.Theboard();

                Random rnd = new Random();
                int sele = rnd.Next(0, 8);

                if (b.board[sele] == "X" || b.board[sele] == "O")
                {
                    TurnWithBot = true;
                    break;

                }
                else
                {
                    b.board[sele] = "O";
                    TurnWithBot = false;
                    legit3 = true;
                }
                
            }
            while (legit3 == false);

            

            /*
                
                if (b.board[0] == "X" & b.board[1] == " " & b.board[2] == " " &
                    b.board[3] == " " & b.board[4] == " " & b.board[5] == " " &
                    b.board[6] == " " & b.board[7] == " " & b.board[8] == " ")
                {
                    b.board[4] = "O";
                    TurnWithBot = false;
                }

                if (b.board[0] == " " & b.board[1] == "X" & b.board[2] == " " &
                    b.board[3] == " " & b.board[4] == " " & b.board[5] == " " &
                    b.board[6] == " " & b.board[7] == " " & b.board[8] == " ")
                {
                    b.board[4] = "O";
                    TurnWithBot = false;
                }

                if (b.board[0] == " " & b.board[1] == " " & b.board[2] == "X" &
                    b.board[3] == " " & b.board[4] == " " & b.board[5] == " " &
                    b.board[6] == " " & b.board[7] == " " & b.board[8] == " ")
                {
                    b.board[4] = "O";
                    TurnWithBot = false;
                }

                if (b.board[0] == " " & b.board[1] == " " & b.board[2] == " " &
                    b.board[3] == "X" & b.board[4] == " " & b.board[5] == " " &
                    b.board[6] == " " & b.board[7] == " " & b.board[8] == " ")
                {
                    b.board[4] = "O";
                    TurnWithBot = false;
                }

                if (b.board[0] == " " & b.board[1] == " " & b.board[2] == " " &
                    b.board[3] == " " & b.board[4] == "X" & b.board[5] == " " &
                    b.board[6] == " " & b.board[7] == " " & b.board[8] == " ")
                {
                    b.board[0] = "O";
                    TurnWithBot = false;
                }

                if (b.board[0] == " " & b.board[1] == " " & b.board[2] == " " &
                    b.board[3] == " " & b.board[4] == " " & b.board[5] == "X" &
                    b.board[6] == " " & b.board[7] == " " & b.board[8] == " ")
                {
                    b.board[4] = "O";
                    TurnWithBot = false;
                }

                if (b.board[0] == " " & b.board[1] == " " & b.board[2] == " " &
                    b.board[3] == " " & b.board[4] == " " & b.board[5] == " " &
                    b.board[6] == "X" & b.board[7] == " " & b.board[8] == " ")
                {
                    b.board[4] = "O";
                    TurnWithBot = false;
                }

                if (b.board[0] == " " & b.board[1] == " " & b.board[2] == " " &
                    b.board[3] == " " & b.board[4] == " " & b.board[5] == " " &
                    b.board[6] == " " & b.board[7] == "X" & b.board[8] == " ")
                {
                    b.board[4] = "O";
                    TurnWithBot = false;
                }

                if (b.board[0] == " " & b.board[1] == " " & b.board[2] == " " &
                    b.board[3] == " " & b.board[4] == " " & b.board[5] == " " &
                    b.board[6] == " " & b.board[7] == " " & b.board[8] == "X")
                {
                    b.board[4] = "O";
                    TurnWithBot = false;
                }



                //NEW
                if (b.board[0] == "X" & b.board[1] == "X" & b.board[2] == " " &
                    b.board[3] == " " & b.board[4] == "O" & b.board[5] == " " &
                    b.board[6] == " " & b.board[7] == " " & b.board[8] == " ")
                {
                    b.board[4] = "X";
                    TurnWithBot = false;
                }
                if (b.board[0] == " " & b.board[1] == "X" & b.board[2] == "X" &
                    b.board[3] == " " & b.board[4] == "O" & b.board[5] == " " &
                    b.board[6] == " " & b.board[7] == " " & b.board[8] == " ")
                {
                    b.board[0] = "O";
                    TurnWithBot = false;
                }

                if (b.board[0] == "X" & b.board[1] == " " & b.board[2] == "X" &
                    b.board[3] == " " & b.board[4] == "O" & b.board[5] == " " &
                    b.board[6] == " " & b.board[7] == " " & b.board[8] == " ")
                {
                    b.board[1] = "O";
                    TurnWithBot = false;
                }

                if (b.board[0] == " " & b.board[1] == " " & b.board[2] == " " &
                    b.board[3] == " " & b.board[4] == "O" & b.board[5] == " " &
                    b.board[6] == "X" & b.board[7] == "X" & b.board[8] == " ")
                {
                    b.board[8] = "O";
                    TurnWithBot = false;
                }

                if (b.board[0] == " " & b.board[1] == " " & b.board[2] == " " &
                    b.board[3] == " " & b.board[4] == "O" & b.board[5] == " " &
                    b.board[6] == " " & b.board[7] == "X" & b.board[8] == "X")
                {
                    b.board[0] = "O";
                    TurnWithBot = false;
                }

                if (b.board[0] == " " & b.board[1] == " " & b.board[2] == " " &
                    b.board[3] == " " & b.board[4] == "O" & b.board[5] == " " &
                    b.board[6] == "X" & b.board[7] == " " & b.board[8] == "X")
                {
                    b.board[7] = "O";
                    TurnWithBot = false;
                }

                if (b.board[0] == "X" & b.board[1] == " " & b.board[2] == " " &
                    b.board[3] == "X" & b.board[4] == "O" & b.board[5] == " " &
                    b.board[6] == " " & b.board[7] == " " & b.board[8] == " ")
                {
                    b.board[6] = "O";
                    TurnWithBot = false;
                }

                if (b.board[0] == "X" & b.board[1] == " " & b.board[2] == " " &
                    b.board[3] == " " & b.board[4] == "O" & b.board[5] == " " &
                    b.board[6] == "X" & b.board[7] == " " & b.board[8] == " ")
                {
                    b.board[3] = "O";
                    TurnWithBot = false;
                }

                if (b.board[0] == " " & b.board[1] == " " & b.board[2] == "X" &
                    b.board[3] == " " & b.board[4] == "O" & b.board[5] == " " &
                    b.board[6] == " " & b.board[7] == " " & b.board[8] == "X")
                {
                    b.board[5] = "O";
                    TurnWithBot = false;
                }

                if (b.board[0] == " " & b.board[1] == " " & b.board[2] == " " &
                    b.board[3] == "X" & b.board[4] == "O" & b.board[5] == " " &
                    b.board[6] == "X" & b.board[7] == " " & b.board[8] == " ")
                {
                    b.board[0] = "O";
                    TurnWithBot = false;
                }

                if (b.board[0] == " " & b.board[1] == " " & b.board[2] == " " &
                    b.board[3] == " " & b.board[4] == "O" & b.board[5] == "X" &
                    b.board[6] == " " & b.board[7] == " " & b.board[8] == "X")
                {
                    b.board[2] = "O";
                    TurnWithBot = false;
                }

                if (b.board[0] == "O" & b.board[1] == "X" & b.board[2] == " " &
                    b.board[3] == " " & b.board[4] == "X" & b.board[5] == " " &
                    b.board[6] == " " & b.board[7] == " " & b.board[8] == " ")
                {
                    b.board[7] = "O";
                    TurnWithBot = false;
                }

                if (b.board[0] == "O" & b.board[1] == " " & b.board[2] == " " &
                    b.board[3] == " " & b.board[4] == "X" & b.board[5] == " " &
                    b.board[6] == " " & b.board[7] == "X" & b.board[8] == " ")
                {
                    b.board[1] = "O";
                    TurnWithBot = false;
                }

                if (b.board[0] == " " & b.board[1] == " " & b.board[2] == "X" &
                    b.board[3] == " " & b.board[4] == "O" & b.board[5] == "X" &
                    b.board[6] == " " & b.board[7] == " " & b.board[8] == " ")
                {
                    b.board[8] = "O";
                    TurnWithBot = false;
                }

                if (b.board[0] == " " & b.board[1] == " " & b.board[2] == " " &
                    b.board[3] == " " & b.board[4] == "O" & b.board[5] == "X" &
                    b.board[6] == " " & b.board[7] == " " & b.board[8] == "X")
                {
                    b.board[2] = "O";
                    TurnWithBot = false;
                }

                if (b.board[0] == " " & b.board[1] == " " & b.board[2] == "X" &
                    b.board[3] == " " & b.board[4] == "O" & b.board[5] == " " &
                    b.board[6] == " " & b.board[7] == " " & b.board[8] == "X")
                {
                    b.board[0] = "O";
                    TurnWithBot = false;
                }

                if (b.board[0] == "O" & b.board[1] == " " & b.board[2] == " " &
                    b.board[3] == "X" & b.board[4] == "X" & b.board[5] == " " &
                    b.board[6] == " " & b.board[7] == " " & b.board[8] == " ")
                {
                    b.board[5] = "O";
                    TurnWithBot = false;
                }

                if (b.board[0] == "O" & b.board[1] == " " & b.board[2] == " " &
                    b.board[3] == " " & b.board[4] == "X" & b.board[5] == "X" &
                    b.board[6] == " " & b.board[7] == " " & b.board[8] == " ")
                {
                    b.board[3] = "O";
                    TurnWithBot = false;
                }

                if (b.board[0] == " " & b.board[1] == " " & b.board[2] == " " &
                    b.board[3] == " " & b.board[4] == "O" & b.board[5] == " " &
                    b.board[6] == "X" & b.board[7] == "X" & b.board[8] == " ")
                {
                    b.board[8] = "O";
                    TurnWithBot = false;
                }

                if (b.board[0] == " " & b.board[1] == " " & b.board[2] == " " &
                    b.board[3] == " " & b.board[4] == "O" & b.board[5] == " " &
                    b.board[6] == " " & b.board[7] == "X" & b.board[8] == "X")
                {
                    b.board[6] = "O";
                    
                }

                if (b.board[0] == " " & b.board[1] == " " & b.board[2] == " " &
                    b.board[3] == " " & b.board[4] == "O" & b.board[5] == " " &
                    b.board[6] == "X" & b.board[7] == " " & b.board[8] == "X")
                {
                    b.board[7] = "O";
                    TurnWithBot = false;
                }

             }


            // NEWWWW
        if (b.board[0] == "X" & b.board[1] == "X" & b.board[2] == "O" &
            b.board[3] == "X" & b.board[4] == "O" & b.board[5] == " " &
            b.board[6] == " " & b.board[7] == " " & b.board[8] == " ")
        {
            b.board[6] = "X";
            TurnWithBot = false;
        }
        if (b.board[0] == "O" & b.board[1] == "X" & b.board[2] == "X" &
            b.board[3] == " " & b.board[4] == "O" & b.board[5] == "X" &
            b.board[6] == " " & b.board[7] == " " & b.board[8] == " ")
        {
            b.board[8] = "O";
            TurnWithBot = false;
        }

        if (b.board[0] == "X" & b.board[1] == "O" & b.board[2] == "X" &
            b.board[3] == "X" & b.board[4] == "O" & b.board[5] == " " &
            b.board[6] == " " & b.board[7] == " " & b.board[8] == " ")
        {
            b.board[6] = "O";
            TurnWithBot = false;
        }


        if (b.board[0] == " " & b.board[1] == " " & b.board[2] == " " &
            b.board[3] == "X" & b.board[4] == "O" & b.board[5] == " " &
            b.board[6] == "X" & b.board[7] == "X" & b.board[8] == "O")
        {
            b.board[0] = "O";
            TurnWithBot = false;
        }

        if (b.board[0] == " " & b.board[1] == " " & b.board[2] == " " &
            b.board[3] == " " & b.board[4] == "O" & b.board[5] == "X" &
            b.board[6] == "O" & b.board[7] == "X" & b.board[8] == "X")
        {
            b.board[2] = "O";
            TurnWithBot = false;
        }

        if (b.board[0] == " " & b.board[1] == " " & b.board[2] == " " &
            b.board[3] == "X" & b.board[4] == "O" & b.board[5] == " " &
            b.board[6] == "X" & b.board[7] == "O" & b.board[8] == "X")
        {
            b.board[0] = "O";
            TurnWithBot = false;
        }

        if (b.board[0] == " " & b.board[1] == " " & b.board[2] == " " &
            b.board[3] == " " & b.board[4] == "O" & b.board[5] == "X" &
            b.board[6] == "X" & b.board[7] == "O" & b.board[8] == "X")
        {
            b.board[2] = "O";
            TurnWithBot = false;
        }

        if (b.board[0] == "X" & b.board[1] == "X" & b.board[2] == " " &
            b.board[3] == "X" & b.board[4] == "O" & b.board[5] == " " &
            b.board[6] == "O" & b.board[7] == " " & b.board[8] == " ")
        {
            b.board[2] = "O";
            TurnWithBot = false;
        }

        if (b.board[0] == "O" & b.board[1] == "X" & b.board[2] == "X" &
            b.board[3] == " " & b.board[4] == "O" & b.board[5] == "X" &
            b.board[6] == " " & b.board[7] == " " & b.board[8] == " ")
        {
            b.board[8] = "O";
            TurnWithBot = false;
        }

        if (b.board[0] == "X" & b.board[1] == "X" & b.board[2] == " " &
            b.board[3] == "O" & b.board[4] == "O" & b.board[5] == " " &
            b.board[6] == "X" & b.board[7] == " " & b.board[8] == " ")
        {
            b.board[2] = "O";
            TurnWithBot = false;
        }

        if (b.board[0] == "X" & b.board[1] == " " & b.board[2] == " " &
            b.board[3] == "O" & b.board[4] == "O" & b.board[5] == " " &
            b.board[6] == "X" & b.board[7] == "X" & b.board[8] == " ")
        {
            b.board[8] = "O";
            TurnWithBot = false;
        }

        if (b.board[0] == " " & b.board[1] == "X" & b.board[2] == "X" &
            b.board[3] == " " & b.board[4] == "O" & b.board[5] == "O" &
            b.board[6] == " " & b.board[7] == " " & b.board[8] == "X")
        {
            b.board[0] = "O";
            TurnWithBot = false;
        }

        if (b.board[0] == " " & b.board[1] == " " & b.board[2] == "X" &
            b.board[3] == " " & b.board[4] == "O" & b.board[5] == "O" &
            b.board[6] == " " & b.board[7] == "X" & b.board[8] == "X")
        {
            b.board[1] = "O";
            TurnWithBot = false;
        }

        if (b.board[0] == "O" & b.board[1] == " " & b.board[2] == " " &
            b.board[3] == "X" & b.board[4] == "O" & b.board[5] == " " &
            b.board[6] == "X" & b.board[7] == "X" & b.board[8] == " ")
        {
            b.board[8] = "O";
            TurnWithBot = false;
        }


        if (b.board[0] == " " & b.board[1] == " " & b.board[2] == "O" &
            b.board[3] == " " & b.board[4] == "O" & b.board[5] == "X" &
            b.board[6] == " " & b.board[7] == "X" & b.board[8] == "X")
        {
            b.board[6] = "O";
            TurnWithBot = false;
        }

        if (b.board[0] == "O" & b.board[1] == "X" & b.board[2] == " " &
            b.board[3] == " " & b.board[4] == "X" & b.board[5] == "X" &
            b.board[6] == " " & b.board[7] == "O" & b.board[8] == " ")
        {
            b.board[3] = "O";
            TurnWithBot = false;
        }

        if (b.board[0] == "O" & b.board[1] == "X" & b.board[2] == " " &
            b.board[3] == "X" & b.board[4] == "X" & b.board[5] == " " &
            b.board[6] == " " & b.board[7] == "O" & b.board[8] == " ")
        {
            b.board[5] = "O";
            TurnWithBot = false;
        }

        if (b.board[0] == "O" & b.board[1] == "O" & b.board[2] == " " &
            b.board[3] == " " & b.board[4] == "X" & b.board[5] == "X" &
            b.board[6] == " " & b.board[7] == "X" & b.board[8] == " ")
        {
            b.board[3] = "O";
            TurnWithBot = false;
        }

        if (b.board[0] == "O" & b.board[1] == "O" & b.board[2] == " " &
            b.board[3] == "X" & b.board[4] == "X" & b.board[5] == " " &
            b.board[6] == " " & b.board[7] == "X" & b.board[8] == " ")
        {
            b.board[5] = "O";
            TurnWithBot = false;
        }

        if (b.board[0] == " " & b.board[1] == "X" & b.board[2] == "X" &
            b.board[3] == " " & b.board[4] == "O" & b.board[5] == "X" &
            b.board[6] == " " & b.board[7] == " " & b.board[8] == "O")
        {
            b.board[0] = "O";
            TurnWithBot = false;
        }

        if (b.board[0] == " " & b.board[1] == " " & b.board[2] == "O" &
            b.board[3] == " " & b.board[4] == "O" & b.board[5] == "X" &
            b.board[6] == " " & b.board[7] == "X" & b.board[8] == "X")
        {
            b.board[6] = "O";
            TurnWithBot = false;
        }

        if (b.board[0] == " " & b.board[1] == "X" & b.board[2] == "X" &
            b.board[3] == " " & b.board[4] == "O" & b.board[5] == "O" &
            b.board[6] == " " & b.board[7] == " " & b.board[8] == "X")
        {
            b.board[0] = "O";
            TurnWithBot = false;
        }

        if (b.board[0] == " " & b.board[1] == " " & b.board[2] == "X" &
            b.board[3] == " " & b.board[4] == "O" & b.board[5] == "O" &
            b.board[6] == " " & b.board[7] == "X" & b.board[8] == "X")
        {
            b.board[6] = "O";
            TurnWithBot = false;
        }

        if (b.board[0] == "O" & b.board[1] == " " & b.board[2] == " " &
            b.board[3] == "X" & b.board[4] == "X" & b.board[5] == "O" &
            b.board[6] == "X" & b.board[7] == " " & b.board[8] == " ")
        {
            b.board[2] = "O";
            TurnWithBot = false;
        }

        if (b.board[0] == "O" & b.board[1] == " " & b.board[2] == "X" &
            b.board[3] == "X" & b.board[4] == "X" & b.board[5] == "O" &
            b.board[6] == " " & b.board[7] == " " & b.board[8] == " ")
        {
            b.board[6] = "O";
            TurnWithBot = false;
        }

        if (b.board[0] == "O" & b.board[1] == " " & b.board[2] == " " &
            b.board[3] == "X" & b.board[4] == "X" & b.board[5] == "O" &
            b.board[6] == " " & b.board[7] == "X" & b.board[8] == " ")
        {
            b.board[1] = "O";
            TurnWithBot = false;
        }

        if (b.board[0] == "O" & b.board[1] == "X" & b.board[2] == " " &
            b.board[3] == "X" & b.board[4] == "X" & b.board[5] == "O" &
            b.board[6] == " " & b.board[7] == " " & b.board[8] == " ")
        {
            b.board[7] = "O";
            TurnWithBot = false;
        }

        if (b.board[0] == "O" & b.board[1] == "X" & b.board[2] == " " &
            b.board[3] == "O" & b.board[4] == "X" & b.board[5] == "X" &
            b.board[6] == " " & b.board[7] == " " & b.board[8] == " ")
        {
            b.board[7] = "O";
            TurnWithBot = false;
        }

        if (b.board[0] == "O" & b.board[1] == " " & b.board[2] == " " &
            b.board[3] == "O" & b.board[4] == "X" & b.board[5] == "X" &
            b.board[6] == " " & b.board[7] == "X" & b.board[8] == " ")
        {
            b.board[1] = "O";
            TurnWithBot = false;
        }

        if (b.board[0] == "O" & b.board[1] == " " & b.board[2] == "X" &
            b.board[3] == "O" & b.board[4] == "X" & b.board[5] == "X" &
            b.board[6] == " " & b.board[7] == " " & b.board[8] == " ")
        {
            b.board[8] = "O";
            TurnWithBot = false;
        }

        if (b.board[0] == "O" & b.board[1] == " " & b.board[2] == " " &
            b.board[3] == "O" & b.board[4] == "X" & b.board[5] == "X" &
            b.board[6] == " " & b.board[7] == " " & b.board[8] == "X")
        {
            b.board[2] = "O";
            TurnWithBot = false;
        }

        if (b.board[0] == " " & b.board[1] == " " & b.board[2] == " " &
            b.board[3] == "X" & b.board[4] == "O" & b.board[5] == " " &
            b.board[6] == "X" & b.board[7] == "X" & b.board[8] == "O")
        {
            b.board[0] = "O";
            TurnWithBot = false;
        }

        if (b.board[0] == "X" & b.board[1] == " " & b.board[2] == " " &
            b.board[3] == "X" & b.board[4] == "O" & b.board[5] == " " &
            b.board[6] == " " & b.board[7] == "X" & b.board[8] == "O")
        {
            b.board[6] = "O";
            TurnWithBot = false;
        }

        if (b.board[0] == " " & b.board[1] == " " & b.board[2] == " " &
            b.board[3] == " " & b.board[4] == "O" & b.board[5] == "X" &
            b.board[6] == "O" & b.board[7] == "X" & b.board[8] == "X")
        {
            b.board[2] = "O";

        }

        if (b.board[0] == " " & b.board[1] == " " & b.board[2] == "X" &
            b.board[3] == " " & b.board[4] == "O" & b.board[5] == "X" &
            b.board[6] == "O" & b.board[7] == "X" & b.board[8] == " ")
        {
            b.board[8] = "O";

        }

        if (b.board[0] == " " & b.board[1] == " " & b.board[2] == " " &
            b.board[3] == "X" & b.board[4] == "O" & b.board[5] == " " &
            b.board[6] == "X" & b.board[7] == "O" & b.board[8] == "X")
        {
            b.board[1] = "O";
            TurnWithBot = false;
        }

        if (b.board[0] == " " & b.board[1] == "X" & b.board[2] == " " &
            b.board[3] == " " & b.board[4] == "O" & b.board[5] == " " &
            b.board[6] == "X" & b.board[7] == "O" & b.board[8] == "X")
        {
            b.board[3] = "O";
            TurnWithBot = false;
        }

        if (b.board[0] == " " & b.board[1] == " " & b.board[2] == " " &
            b.board[3] == " " & b.board[4] == "O" & b.board[5] == "X" &
            b.board[6] == "X" & b.board[7] == "O" & b.board[8] == "X")
        {
            b.board[1] = "O";
            TurnWithBot = false;
        }
        */
        }

    }


    public void plays1()
    {

        legit = false;
        do
        {
            Console.Clear();
            Console.WriteLine("player: " + player1 + " turn");
            b.Theboard();
            Console.WriteLine("select which one to X");
            pos = Console.ReadLine();

            switch (pos)
            {



                case "1":
                    if (b.board[0] == "O" || b.board[0] == "X")
                    {
                        turn = false;
                        break;

                    }
                    b.board[0] = "X";
                    turn = true;
                    TurnWithBot = true;
                    legit = true;
                    break;

                case "2":
                    if (b.board[1] == "O" || b.board[1] == "X")
                    {
                        turn = false;
                        break;

                    }
                    b.board[1] = "X";
                    turn = true;
                    TurnWithBot = true;
                    legit = true;
                    break;

                case "3":
                    if (b.board[2] == "O" || b.board[2] == "X")
                    {
                        turn = false;
                        break;

                    }
                    b.board[2] = "X";
                    turn = true;
                    TurnWithBot = true;
                    legit = true;
                    break;

                case "4":
                    if (b.board[3] == "O" || b.board[3] == "X")
                    {
                        turn = false;
                        break;

                    }
                    b.board[3] = "X";
                    turn = true;
                    TurnWithBot = true;
                    legit = true;
                    break;

                case "5":
                    if (b.board[4] == "O" || b.board[4] == "X")
                    {
                        turn = false;
                        break;

                    }
                    b.board[4] = "X";
                    turn = true;
                    TurnWithBot = true;
                    legit = true;
                    break;

                case "6":
                    if (b.board[5] == "O" || b.board[5] == "X")
                    {
                        turn = false;
                        break;

                    }
                    b.board[5] = "X";
                    turn = true;
                    TurnWithBot = true;
                    legit = true;
                    break;

                case "7":
                    if (b.board[6] == "O" || b.board[6] == "X")
                    {
                        turn = false;
                        break;

                    }
                    b.board[6] = "X";
                    turn = true;
                    TurnWithBot = true;
                    legit = true;
                    break;

                case "8":
                    if (b.board[7] == "O" || b.board[7] == "X")
                    {
                        turn = false;
                        break;

                    }
                    b.board[7] = "X";
                    turn = true;
                    TurnWithBot = true;
                    legit = true;
                    break;

                case "9":
                    if (b.board[8] == "O" || b.board[8] == "X")
                    {
                        turn = false;
                        break;

                    }
                    b.board[8] = "X";
                    turn = true;
                    TurnWithBot = true;
                    legit = true;
                    break;
            }

        }
        while (legit == false);
    
                }

    public void plays2()
    {
        
        
        

            
       
            legit2 = false;
            do
            {
                Console.Clear();
                Console.WriteLine("player: " + player2 + " turn");
                b.Theboard();
                Console.WriteLine("select which one to O");
                pos = Console.ReadLine();
                switch (pos)
                {
                    case "1":
                        if (b.board[0] == "X" || b.board[0] == "O")
                        {
                            turn = true;
                            break;

                        }
                        b.board[0] = "O";
                        turn = false;
                        legit2 = true;
                        break;

                    case "2":
                        if (b.board[1] == "X" || b.board[1] == "O")
                        {
                            turn = true;
                            break;

                        }
                        b.board[1] = "O";
                        turn = false;
                        legit2 = true;
                        break;

                    case "3":
                        if (b.board[2] == "X" || b.board[2] == "O")
                        {
                            turn = true;
                            legit2 = true;
                            break;

                        }
                        b.board[2] = "O";
                        turn = false;
                        legit2 = true;
                        break;

                    case "4":
                        if (b.board[3] == "X" || b.board[3] == "O")
                        {
                            turn = true;
                            legit2 = true;
                            break;

                        }
                        b.board[3] = "O";
                        turn = false;
                        legit2 = true;
                        break;

                    case "5":
                        if (b.board[4] == "X" || b.board[4] == "O")
                        {
                            turn = true;
                            break;

                        }
                        b.board[4] = "O";
                        turn = false;
                        legit2 = true;
                        break;

                    case "6":
                        if (b.board[5] == "X" || b.board[5] == "O")
                        {
                            turn = true;
                            break;

                        }
                        b.board[5] = "O";
                        turn = false;
                        legit2 = true;
                        break;

                    case "7":
                        if (b.board[6] == "X" || b.board[6] == "O")
                        {
                            turn = true;
                            break;

                        }
                        b.board[6] = "O";
                        turn = false;
                        legit2 = true;
                        break;

                    case "8":
                        if (b.board[7] == "X" || b.board[7] == "O")
                        {
                            turn = true;
                            break;

                        }
                        b.board[7] = "O";
                        turn = false;
                        legit2 = true;
                        break;

                    case "9":
                        if (b.board[8] == "X" || b.board[8] == "O")
                        {
                            turn = true;
                            break;

                        }
                        b.board[8] = "O";
                        turn = false;
                        legit2 = true;
                        break;
                }
            }
            while (legit2 == false);
        }    

    }
    
 
