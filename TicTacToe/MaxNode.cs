//************************************************************************************
//
// Programmerare: Didi-Iulia Tudose, Emil Svärd Mårtensson, Murat Demir
// Systemutveckling, Plushögskolan i Malmö
// Lärare: Thomas Frank
//
//************************************************************************************

class MaxNode : Node
{
    public MaxNode(Board gamestate, int move, Node parent, int value)
        : base("max", move, parent, value)
    {
        this.board = new Board(gamestate.board);
    }
}
