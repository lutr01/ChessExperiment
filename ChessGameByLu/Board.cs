using ChessGameByLu.Pieces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ChessGameByLu
{
    /// <summary>
    /// describes the board and holds all the current positions of chess pieces
    /// </summary>
    public static class Board
    {
        public static Dictionary<KeyValuePair<string, int>, ChessPiece> boardCells =
            new Dictionary<KeyValuePair<string, int>, ChessPiece>() { };
        private static string[] rows = { "A", "B", "C", "D", "E", "F", "G", "H" };
        private static  int[] columns = { 1, 2, 3, 4, 5, 6, 7, 8 };
        private static readonly int[] rowsNum = { 1, 2, 3, 4, 5, 6, 7, 8 };

        public static void Initiate()
        {
            
            foreach (int row in rowsNum)
            {
                foreach (int column in columns)
                {
                    KeyValuePair<string, int> key = 
                        new KeyValuePair<string, int>(rows[row - 1], columns[column - 1]);
                
                    boardCells.Add(key, null);
                }
            }

        }
        /// <summary>
        /// updates the position of the piece
        /// </summary>
        /// <param name="initialPosition">the starting position of the piece</param>
        /// <param name="finalPosition">final position of the chess</param>
        public static void UpdatePosition(KeyValuePair<string, int> initialPosition,
            KeyValuePair<string, int> finalPosition)
        {
            ChessPiece currentPiece = boardCells[initialPosition];
            boardCells[initialPosition] = null;
            boardCells[finalPosition] = currentPiece;
        }
        /// <summary>
        /// gets the current piece on the specific cell
        /// </summary>
        /// <param name="position">the key-value pair of letter and number indicating cell's address</param>
        /// <returns></returns>
        public static ChessPiece GetFigureAtCell(KeyValuePair<string, int> position)
        {
            return boardCells[position];
        }
        /// <summary>
        /// Checks if the passed cell's address is inside of the board's boundaries
        /// </summary>
        /// <param name="position">the key-value pair of letter and number indicating cell's address</param>
        /// <returns></returns>
        public static bool IsInBoundaries(KeyValuePair<string, int> position)
        {
            if (rows.Contains(position.Key.ToUpper()) && columns.Contains(position.Value))
            {
                return true;
            }
            return false;
        }
        /// <summary>
        /// Compares the initial and final positions' addresses
        /// </summary>
        /// <param name="initialPosition">address of initial cell</param>
        /// <param name="finalPosition">address of final cell</param>
        /// <returns>the resulted value in key-value pair representation</returns>
        public static KeyValuePair<int, int> CompareCells(KeyValuePair<string, int> initialPosition,
            KeyValuePair<string, int> finalPosition)
        {
            int cii = Array.FindIndex(rows, row => row == initialPosition.Key);
            int rii = Array.FindIndex(columns, column => column == initialPosition.Value);

            int cfi = Array.FindIndex(rows, row => row == finalPosition.Key);
            int rfi = Array.FindIndex(columns, column => column == finalPosition.Value);

            KeyValuePair<int, int> dif = new KeyValuePair<int, int>(rfi - rii, cfi - cii);
            return dif;
        }
    }
}
