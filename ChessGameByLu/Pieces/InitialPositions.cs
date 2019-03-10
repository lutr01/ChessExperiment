using System.Collections.Generic;

namespace ChessGameByLu.Pieces
{
    public static class InitialPositions
    {
        public static Dictionary<Dictionary<string, int>, ChessPiece> initalPosition =
            new Dictionary<Dictionary<string, int>, ChessPiece>()
            {

                {new Dictionary<string, int>{ {"A", 1 }, {"H", 1 }  }, new ChessPiece("rook", "white") },
                {new Dictionary<string, int>{ {"B", 1 }, {"G", 1 } }, new ChessPiece("knight", "white") },
                {new Dictionary<string, int>{ {"C", 1 }, {"F", 1 } }, new ChessPiece("bishop", "white") },
                {new Dictionary<string, int>{ {"D", 1 } }, new ChessPiece("king", "white") },
                {new Dictionary<string, int>{ {"E", 1 } }, new ChessPiece("queen", "white") },
                {new Dictionary<string, int>{
                    { "A", 2 }, {"B", 2 }, {"C", 2 }, {"D", 2 }, {"E", 2 }, {"F", 2 }, {"G", 2 }, {"H", 2 } },
                    new ChessPiece("pawn", "white") },
                {new Dictionary<string, int>{ {"A", 8 }, {"H", 8 }  }, new ChessPiece("rook", "black") },
                {new Dictionary<string, int>{ {"B", 8 }, {"G", 8 } }, new ChessPiece("knight", "black") },
                {new Dictionary<string, int>{ {"C", 8 }, {"F", 8 } }, new ChessPiece("bishop", "black") },
                {new Dictionary<string, int>{ {"D", 8 } }, new ChessPiece("king", "black") },
                {new Dictionary<string, int>{ {"E", 8 } }, new ChessPiece("queen", "black") },
                {new Dictionary<string, int>{
                    { "A", 7 }, {"B", 7 }, {"C", 7 }, {"D", 7 }, {"E", 7 }, {"F", 7 }, {"G", 7 }, {"H", 7 } },
                    new ChessPiece("pawn", "black") },
            };

        public static void SendToBoard()
        {
            foreach (var item in initalPosition)
            {
                foreach (var cell in item.Key)
                {
                    Board.boardCells[cell] = item.Value;

                }
            }
        }

    }
}
