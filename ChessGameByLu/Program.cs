using ChessGameByLu.Pieces;
using System;
using System.Collections.Generic;

namespace ChessGameByLu
{
    internal class Program
    {
        private static void Main(string[] args)
        {

            Board.Initiate(); // makes the board with all empty cells

            Console.WriteLine("board ready");

            InitialPositions.SendToBoard(); // puts all the pieces on the initial positions

            Console.WriteLine("pieces sent to the board");

            Moving move = new Moving(); // instanciates a move

            move.Move(new KeyValuePair<string, int>("B", 1), new KeyValuePair<string, int>("A", 3)); // valid move of the knight

            Console.WriteLine("Movement was made");

            move.Move(new KeyValuePair<string, int>("A", 3), new KeyValuePair<string, int>("C", 4)); // valid move of the knight

            Console.WriteLine("Movement was made");

            Console.ReadKey();

        }
    }
}
