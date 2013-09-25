using System;

class Program
{
    static void Main()
    {
        Board board1 = new Board();
        board1.drawBoard();

        Player player1 = new Player("X");
        int xpos, ypos;

        do
        {
            ypos = player1.inputY();
            xpos = player1.inputX();
            board1.place(xpos, ypos);
            board1.drawBoard();
        } while (ypos != 9);

    }
}

