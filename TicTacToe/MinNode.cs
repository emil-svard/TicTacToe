//************************************************************************************
// 
// Programmerare: Didi-Iulia Tudose, Emil Svärd Mårtensson, Murat Demir
// Systemutveckling, Plushögskolan i Malmö
// Lärare: Thomas Frank
//
//************************************************************************************

class MinNode : Node
{
    public MinNode(Board gamestate, int move, Node parent, int value)
        : base("min", move, parent, value)
    {
        this.board = new Board(gamestate.board);
    }
}
