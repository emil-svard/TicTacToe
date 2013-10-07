//************************************************************************************
//
// Programmerare: Didi-Iulia Tudose, Emil Svärd Mårtensson, Murat Demir
// Systemutveckling, Plushögskolan i Malmö
// Lärare: Thomas Frank
//
//************************************************************************************

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

class Computer : Player
{

    public int SearchDepth { get; set; }

    public Computer(string name, int piece, int searchDepth)
        : base(name, piece)
    {
        this.SearchDepth = searchDepth;
    }


    override public void Move(Board gamestate)
    {
        // The code in this method is an attempt at a non-recursive minimax algorithm (breadth first traversal)

        if (gamestate.OpenPositions().Length == 9) // if the board is empty...
        {
            gamestate.Place(GetRandomMove(gamestate), Piece, this.Name); // ...place the piece at a random square
            return;
        }

        int currentDepth = 0; // to keep track of the tree depth
        int currentPiece = Piece; // we start with placing the computer piece (on a min node)
        int value = 0; // variable for the current evaluation value
        List<Node> NodeTree = new List<Node>(); // tree list that contains all nodes created (breadth first)
        List<Node> CurrentParentNodes = new List<Node>(); // to keep track of the current parent nodes. all children become parent nodes to be able to process new children
        List<Node> CurrentChildrenNodes = new List<Node>(); // to keep track of the current children
        CurrentParentNodes.Add(new MaxNode(gamestate, -999, null, 0)); // adds and creates the first computer max root node
        NodeTree.AddRange(CurrentParentNodes); // add the first computer max root node to the entire tree of nodes which at this point is empty before this add

        while (currentDepth != SearchDepth) // end loop if SearchDepth is reached
        {

            for (int i = 0; i < CurrentParentNodes.Count; i++) // process the current parents, which in the first loop iteration involves the root node
            {
                int[] openPositions = CurrentParentNodes[i].board.OpenPositions(); // puts the open positions on the current parent board into an array
                for (int j = 0; j < openPositions.Length; j++) // loop through this array of open positions
                {
                    //TicTacToeMove m = new TicTacToeMove(i, Piece);
                    Board b = new Board(CurrentParentNodes[i].board.board); // create a new board based on the board of the current parent
                    b.Place(openPositions[j], currentPiece, this.Name); // place piece on whatever open position we are on
                    value = Evaluate(b, Piece, openPositions[j]); // evaluate the current board
                    //if (value == int.MaxValue)
                      //  Console.WriteLine("Vi har en vinnare");


                    if (currentPiece == -1) // !!! POSSIBLE (FUTURE) ERROR // if the current piece is -1 (O)
                        CurrentChildrenNodes.Add(new MinNode(b, openPositions[j], CurrentParentNodes[i], value)); // add a new minnode to the list of children nodes
                    else
                        CurrentChildrenNodes.Add(new MaxNode(b, openPositions[j], CurrentParentNodes[i], value)); // add a new maxnode to the list of children nodes

                }
                CurrentParentNodes[i].Children.AddRange(CurrentChildrenNodes); // put the children in the parents list
            }

            CurrentParentNodes.Clear(); // clear the parents
            CurrentParentNodes.AddRange(CurrentChildrenNodes); // make the children parents
            NodeTree.AddRange(CurrentChildrenNodes); // add the children to the big tree
            CurrentChildrenNodes.Clear(); // clear the children
            currentDepth++; // increase the depth by one level
            currentPiece *= -1; // change what piece we are on, after the computers turn it is the player's turn
        }

        /*
        Console.WriteLine();
        for (int i = 0; i < NodeTree.Count; i++)
        {
            if (NodeTree[i].Children.Count != 0)
                Console.Write(NodeTree[i].Value + ": ");
            for (int j = 0; j < NodeTree[i].Children.Count; j++)
            {
                Console.Write(NodeTree[i].Children[j].Value + ", ");
            }
            Console.Write("\n");
        }
        Console.ReadLine();
        */



        for (int i = NodeTree.Count - 1; i >= 0; i--) // loop through the entire node tree containing all nodes created... because the values from the nodes furthest down in the tree should be inherited from nodes higher up in the tree we start by looping backwards
        {
            if (NodeTree[i].Children.Count != 0) // if the current node has children, continue
            {
                if (NodeTree[i].Type == "max") // if the current node is a maxnode, continue
                {
                    int[] data = GetMaxValue(NodeTree[i].Children); // get the max value from the current node's children
                    NodeTree[i].Value = data[0]; // give the maxvalue from the children to the current node
                    if (i == 0) // if we are on the first max root node
                    {
                        NodeTree[0].Move = data[1]; // the move that should be taken to follow what the max value instructs
                    }
                }

                else if (NodeTree[i].Type == "min") // if the current node is a min node
                {
                    int minValue = GetMinValue(NodeTree[i].Children); // get the min value from the children of the current node
                    NodeTree[i].Value = minValue; // give the min value to the current node
                }

            }
        }

        
        Console.Write("\n" + this.Name + " is thinking..."); // to simulate that the computer is thinking
        Thread.Sleep(2000);
        gamestate.Place(NodeTree[0].Move, Piece, this.Name); // place the piece on what is supposed to be the optimal square

    }

    public int GetRandomMove(Board b)
    {
        int openPositions = b.OpenPositions().Length;
        Random rGen = new Random();
        int squareToMoveTo = rGen.Next(openPositions);
        return squareToMoveTo;
    }


    private int[] GetMaxValue(List<Node> unsortedChildren)
    {
        int[] data = new int[2];
        List<Node> sortedChildren = unsortedChildren.OrderByDescending(n => n.Value).ToList(); // sort the list so that the biggest value ends up at index 0
        data[0] = sortedChildren[0].Value;
        data[1] = sortedChildren[0].Move;
        return data;
    }

    private int GetMinValue(List<Node> unsortedChildren)
    {
        List<Node> sortedChildren = unsortedChildren.OrderBy(n => n.Value).ToList(); // sort the list so that the smallest value ends up at index 0
        return sortedChildren[0].Value;
    }


    public int Evaluate(Board b, int piece, int position)
    {
        if (b.HasWinner(position)) // if there is a winner on the current board
        {
            if (b.Winner == piece) // if the winner is the computer piece
                return int.MaxValue; // return a very big value to mark that it is very positive for the computer
            else
                return int.MinValue; // return a very small value to mark that it is very negative for the computer
        }

        int maxValue = EvaluatePiece(b, piece); // evaluate the score for board b for the computer piece (always a computer)
        int minValue = EvaluatePiece(b, piece * -1); // evaluate the score on board b for the opponent piece

        return maxValue - minValue; // return the difference between these values
    }



    public int EvaluatePiece(Board b, int piece)
    {
        return EvaluateRows(b, piece) + EvaluateCols(b, piece) + EvaluateDiagonals(b, piece);
    }


    // checks the rows for how many times the piece occurs in a row and returns the score only if it is a row in which the piece can still win
     private int EvaluateRows(Board b, int piece)
    {
        int cols = b.COLS;
        int rows = b.ROWS;

        int score = 0;
        int count;

        for (int i = 0; i < b.ROWS; i++)
        {
            count = 0;
            bool rowClean = true;
            for (int j = 0; j < b.COLS; j++)
            {
                int boardPiece = b.GetPieceAtPoint(i, j);

                if (boardPiece == piece)
                    count++;
                else if (boardPiece == piece * -1)
                {
                    rowClean = false;
                    break;
                }
            }

            // if we get here then the row is clean (an open row)
            if (rowClean && count != 0)
                score += count;
        }

        return score;
    }

     // checks the columns for how many times the piece occurs in a column and returns the score only if it is a column in which the piece can still win
    private int EvaluateCols(Board b, int piece)
    {
        int cols = b.COLS;
        int rows = b.ROWS;

        int score = 0;
        int count;

        for (int j = 0; j < b.ROWS; j++)
        {
            count = 0;
            bool rowClean = true;
            for (int i = 0; i < b.COLS; i++)
            {
                int boardPiece = b.GetPieceAtPoint(i, j);

                if (boardPiece == piece)
                    count++;
                else if (boardPiece == piece * -1)
                {
                    rowClean = false;
                    break;
                }
            }

            // if we get here then the row is clean (an open row)
            if (rowClean && count != 0)
                score += count;

        }

        return score;
    }


    // checks the diagonals
    private int EvaluateDiagonals(Board b, int piece)
    {
        int count = 0;
        bool diagonalClean = true;

        int score = 0;

        for (int i = 0; i < b.COLS; i++)
        {
            int boardPiece = b.GetPieceAtPoint(i, i);

            if (boardPiece == piece)
                count++;

            if (boardPiece == piece * -1)
            {
                diagonalClean = false;
                break;
            }
        }

        if (diagonalClean && count > 0)
            score += count;

        
        // anti-diagonal

        int row = 0;
        int col = 2;
        count = 0;
        diagonalClean = true;

        while (row < b.ROWS && col >= 0)
        {
            int boardPiece = b.GetPieceAtPoint(row, col);

            if (boardPiece == piece)
                count++;

            if (boardPiece == piece * -1)
            {
                diagonalClean = false;
                break;
            }

            row++;
            col--;
        }

        if (count > 0 && diagonalClean)
            score += count;

        return score;
    }
}

