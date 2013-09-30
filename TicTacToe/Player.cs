using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class player
{
 List<string> board = new List<string> { " ", " ", " ", " ", " ", " ", " ", " ", " "};
    public string player1, player2, pos;
    public bool turn;
    public string playerbot = "Mr.Bot";
    public bool playagain;
    public bool legit;
    public bool legit2;
    

    public void WinnerText()
    {
        if (turn == true)
        {
            Console.WriteLine("You win " + player1);
        }
        if (turn == false)
        {
            Console.WriteLine("You win " + player2);
        }
        
        Console.WriteLine("Do you want to play again? Y/N");
        pos = Console.ReadLine();
        if (pos == "Y")
        {
            playagain = true;
        }
        else
        {
            Console.WriteLine("Thanks for playing!");
            Environment.Exit(0);
        }

    }
    public void Credit()
    {
        Console.WriteLine("Thanks for playing!");
        Console.WriteLine("Good Bye!");
        // useless atm

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
        playagain = false;

    }
    public void isit()
    {
        foreach (var x in board)
        {
            if (x == "X")
                {
                 
                break;
                } 
        }
    }

    
    public void Win()
    {
        if (board[0] == "X" & board[1] == "X" & board[2] == "X")
            WinnerText();
        if (board[3] == "X" & board[4] == "X" & board[5] == "X")
            WinnerText();
        if (board[6] == "X" & board[7] == "X" & board[8] == "X")
            WinnerText();
        if (board[0] == "X" & board[3] == "X" & board[6] == "X")
            WinnerText();
        if (board[0] == "X" & board[4] == "X" & board[8] == "X")
            WinnerText();
        if (board[2] == "X" & board[4] == "X" & board[6] == "X")
            WinnerText();
        if (board[1] == "X" & board[4] == "X" & board[7] == "X")
            WinnerText();
        if (board[2] == "X" & board[5] == "X" & board[8] == "X")
            WinnerText();
    }

    public void Win2()
    {
        if (board[0] == "O" & board[1] == "O" & board[2] == "O")
            WinnerText();
        if (board[3] == "O" & board[4] == "O" & board[5] == "O")
            WinnerText();
        if (board[6] == "O" & board[7] == "O" & board[8] == "O")
            WinnerText();
        if (board[0] == "O" & board[3] == "O" & board[6] == "O")
            WinnerText();
        if (board[0] == "O" & board[4] == "O" & board[8] == "O")
            WinnerText();
        if (board[2] == "O" & board[4] == "O" & board[6] == "O")
            WinnerText();
        if (board[1] == "O" & board[4] == "O" & board[7] == "O")
            WinnerText();
        if (board[2] == "O" & board[5] == "O" & board[8] == "O")
            WinnerText();
    }

    public void bot()
    {
        if (turn == true)
        {
            legit2 = false;
            while (legit2 == false)
            {



                Console.Clear();
                Console.WriteLine("player: " + playerbot + " turn");
                Console.WriteLine("\n");
                Console.WriteLine(board[0] + "│" + board[1] + "│" + board[2]);
                Console.WriteLine("─┼─┼─");
                Console.WriteLine(board[3] + "│" + board[4] + "│" + board[5]);
                Console.WriteLine("─┼─┼─");
                Console.WriteLine(board[6] + "│" + board[7] + "│" + board[8]);
                Console.WriteLine("────────────────────────────");
                Console.WriteLine("select which one to O");

                
                

            }

            }
        }
    

    public void plays1()
    {

        if (turn == false)
	{
        legit = false;
        while (legit == false)
        {



            Console.Clear();
            Console.WriteLine("player: " + player1 + " turn");
            Console.WriteLine("\n");
            Console.WriteLine(board[0] + "│" + board[1] + "│" + board[2]);
            Console.WriteLine("─┼─┼─");
            Console.WriteLine(board[3] + "│" + board[4] + "│" + board[5]);
            Console.WriteLine("─┼─┼─");
            Console.WriteLine(board[6] + "│" + board[7] + "│" + board[8]);
            Console.WriteLine("────────────────────────────");
            Console.WriteLine("select which one to X");
            pos = Console.ReadLine();



            switch (pos)
            {



                case "1":
                    if (board[0] == "O" || board[0] == "X")
                    {
                        turn = false;
                        break;

                    }
                    board[0] = "X";
                    turn = true;
                    legit = true;
                    break;

                case "2":
                    if (board[1] == "O" || board[1] == "X")
                    {
                        turn = false;
                        break;

                    }
                    board[1] = "X";
                    turn = true;
                    legit = true;
                    break;

                case "3":
                    if (board[2] == "O" || board[2] == "X")
                    {
                        turn = false;
                        break;

                    }
                    board[2] = "X";
                    turn = true;
                    legit = true;
                    break;

                case "4":
                    if (board[3] == "O" || board[3] == "X")
                    {
                        turn = false;
                        break;

                    }
                    board[3] = "X";
                    turn = true;
                    legit = true;
                    break;

                case "5":
                    if (board[4] == "O" || board[4] == "X")
                    {
                        turn = false;
                        break;

                    }
                    board[4] = "X";
                    turn = true;
                    legit = true;
                    break;

                case "6":
                    if (board[5] == "O" || board[5] == "X")
                    {
                        turn = false;
                        break;

                    }
                    board[5] = "X";
                    turn = true;
                    legit = true;
                    break;

                case "7":
                    if (board[6] == "O" || board[6] == "X")
                    {
                        turn = false;
                        break;

                    }
                    board[6] = "X";
                    turn = true;
                    legit = true;
                    break;

                case "8":
                    if (board[7] == "O" || board[7] == "X")
                    {
                        turn = false;
                        break;

                    }
                    board[7] = "X";
                    turn = true;
                    legit = true;
                    break;

                case "9":
                    if (board[8] == "O" || board[8] == "X")
                    {
                        turn = false;
                        break;

                    }
                    board[8] = "X";
                    turn = true;
                    legit = true;
                    break;
            }

        }    
                }

            }

    public void plays2()
    {
        
        if (turn == true)
            
        {
            legit2 = false;
            while (legit2 == false)
            {

                Console.Clear();
                Console.WriteLine("player: " + player2 + " turn");
                Console.WriteLine("\n");
                Console.WriteLine(board[0] + "│" + board[1] + "│" + board[2]);
                Console.WriteLine("─┼─┼─");
                Console.WriteLine(board[3] + "│" + board[4] + "│" + board[5]);
                Console.WriteLine("─┼─┼─");
                Console.WriteLine(board[6] + "│" + board[7] + "│" + board[8]);
                Console.WriteLine("────────────────────────────");
                Console.WriteLine("select which one to O");
                pos = Console.ReadLine();


                switch (pos)
                {
                    case "1":
                        if (board[0] == "X" || board[0] == "O")
                        {
                            turn = true;
                            break;

                        }
                        board[0] = "O";
                        turn = false;
                        legit2 = true;
                        break;

                    case "2":
                        if (board[1] == "X" || board[1] == "O")
                        {
                            turn = true;
                            break;

                        }
                        board[1] = "O";
                        turn = false;
                        legit2 = true;
                        break;

                    case "3":
                        if (board[2] == "X" || board[2] == "O")
                        {
                            turn = true;
                            legit2 = true;
                            break;

                        }
                        board[2] = "O";
                        turn = false;
                        legit2 = true;
                        break;

                    case "4":
                        if (board[3] == "X" || board[3] == "O")
                        {
                            turn = true;
                            legit2 = true;
                            break;

                        }
                        board[3] = "O";
                        turn = false;
                        legit2 = true;
                        break;

                    case "5":
                        if (board[4] == "X" || board[4] == "O")
                        {
                            turn = true;
                            break;

                        }
                        board[4] = "O";
                        turn = false;
                        legit2 = true;
                        break;

                    case "6":
                        if (board[5] == "X" || board[5] == "O")
                        {
                            turn = true;
                            break;

                        }
                        board[5] = "O";
                        turn = false;
                        legit2 = true;
                        break;

                    case "7":
                        if (board[6] == "X" || board[6] == "O")
                        {
                            turn = true;
                            break;

                        }
                        board[6] = "O";
                        turn = false;
                        legit2 = true;
                        break;

                    case "8":
                        if (board[7] == "X" || board[7] == "O")
                        {
                            turn = true;
                            break;

                        }
                        board[7] = "O";
                        turn = false;
                        legit2 = true;
                        break;

                    case "9":
                        if (board[8] == "X" || board[8] == "O")
                        {
                            turn = true;
                            break;

                        }
                        board[8] = "O";
                        turn = false;
                        legit2 = true;
                        break;
                }
            }
        }    

    }
 }
