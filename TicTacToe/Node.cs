//************************************************************************************
//
// Programmerare: Didi-Iulia Tudose, Emil Svärd Mårtensson, Murat Demir
// Systemutveckling, Plushögskolan i Malmö
// Lärare: Thomas Frank
//
//************************************************************************************

using System;
using System.Collections.Generic;

class Node
{
    public Board board { get; set; }
    public string Type { get; set; }
    public int Move { get; set; }
    public int Value { get; set; }
    public Node Parent { get; set; }
    public List<Node> Children { get; set; }

    public Node(string type, int move, Node parent, int value)
    {
        this.Children = new List<Node>();
        this.Type = type;
        this.Move = move;
        this.Parent = parent;
        this.Value = value;

    }
}
