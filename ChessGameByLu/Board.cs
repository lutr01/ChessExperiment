using ChessGameByLu.Pieces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ChessGameByLu
{
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

        public static void UpdatePosition(KeyValuePair<string, int> initialPosition,
            KeyValuePair<string, int> finalPosition)
        {
        }

        public static ChessPiece GetFigureAtCell(KeyValuePair<string, int> position)
        {
            return boardCells[position];
        }

        public static bool IsInBoundaries(KeyValuePair<string, int> position)
        {
            if (rows.Contains(position.Key.ToUpper()) && columns.Contains(position.Value))
            {
                return true;
            }
            return false;
        }

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
