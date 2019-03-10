using ChessGameByLu.Pieces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ChessGameByLu
{
    class Program
    {
        static void Main(string[] args)
        {
            //string player1;
            //string player2;
            //string player1Color;
            //string player2Color;
            //string[] colors = new string[2] { "black", "white" };

            //Console.WriteLine("Name of Player 1 : ");
            //player1 = Console.ReadLine();
            //Console.WriteLine("Name of Player 2 : ");
            //player2 = Console.ReadLine();
            //Console.WriteLine("Color for Player 1 : ");
            //player1Color = Console.ReadLine();
            //while (!colors.Contains(player1Color.ToLower()))
            //{
            //    Console.WriteLine("Color was invalid, please choose black or white : ");
            //    player1Color = Console.ReadLine().ToLower();
            //}

            //if (player1Color.ToLower() == "black")
            //{
            //    player2Color = "white";
            //}
            //else if (player1Color.ToLower() == "white")
            //{
            //    player2Color = "black";
            //}
            //else
            //{
            //    throw new ArgumentException("Something went wrong, check your code");
            //}

            //Console.WriteLine($"Color for {player1} : {player1Color}");

            //Console.WriteLine($"Color for {player2} : {player2Color}");

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
