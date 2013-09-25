using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class player
{
    List<string> board = new List<string> { " ", " ", " ", " ", " ", " ", " ", " ", " " };

    public string player1, player2, pos;
    public bool turn = false;
    public bool won = false;


    public void Winner()
    {
        if (board[0] == board[1] & board[1] == board[2])
        {
            won = true;
            Console.WriteLine("You win" + player1);

        }
        if (board[3] == board[4] & board[4] == board[5])
        {

            won = true;
            Console.WriteLine("You win" + player1);
        }
        if (board[6] == board[7] & board[7] == board[8])
        {
            won = true;
            Console.WriteLine("You win" + player1);
        }

        
    }

    
    public void plays1()
    {

        if (turn == true)
	{



        
                    Console.Clear();
                    Console.WriteLine("player: " + player1 + " turn");
                    Console.WriteLine("\n");
                    Console.WriteLine(board[0] + "|" + board[1] + "|" + board[2]);
                    Console.WriteLine(board[3] + "|" + board[4] + "|" + board[5]);
                    Console.WriteLine(board[6] + "|" + board[7] + "|" + board[8]);
                    Console.WriteLine("------------------------------------");
                    Console.WriteLine("select which one to X");
                    pos = Console.ReadLine();


                    switch (pos)
                    {
                        case "1":
                            board[0] = "X";
                            break;

                        case "2":
                            board[1] = "X";
                            break;

                        case "3":
                            board[2] = "X";
                            break;

                        case "4":
                            board[3] = "X";
                            break;

                        case "5":
                            board[4] = "X";
                            break;

                        case "6":
                            board[5] = "X";
                            break;

                        case "7":
                            board[6] = "X";
                            break;

                        case "8":
                            board[7] = "X";
                            break;

                        case "9":
                            board[8] = "X";
                            break;


                            


                    }

                }


            }
    public void plays2()
    {
        
        if (turn == false)
            
        {



            
            Console.Clear();
            Console.WriteLine("player: " + player2 + " turn");
            Console.WriteLine("\n");
            Console.WriteLine(board[0] + "|" + board[1] + "|" + board[2]);
            Console.WriteLine(board[3] + "|" + board[4] + "|" + board[5]);
            Console.WriteLine(board[6] + "|" + board[7] + "|" + board[8]);
            Console.WriteLine("------------------------------------");
            Console.WriteLine("select which one to O");
            pos = Console.ReadLine();


            switch (pos)
            {
                case "1":
                    board[0] = "O";
                    break;

                case "2":
                    board[1] = "O";
                    break;

                case "3":
                    board[2] = "O";
                    break;

                case "4":
                    board[3] = "O";
                    break;

                case "5":
                    board[4] = "O";
                    break;

                case "6":
                    board[5] = "O";
                    break;

                case "7":
                    board[6] = "O";
                    break;

                case "8":
                    board[7] = "O";
                    break;

                case "9":
                    board[8] = "O";
                    break;





            }

        }


    }

        }