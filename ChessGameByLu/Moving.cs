using ChessGameByLu.MovementRules;
using ChessGameByLu.Pieces;
using System;
using System.Collections.Generic;

namespace ChessGameByLu
{
    public class Moving
    {
        public void Move(KeyValuePair<string, int> initialPosition, KeyValuePair<string, int> finalPosition)
        {
            ChessPiece currentPiece = Board.boardCells[initialPosition];

            MovementRuleByName movementRule = new MovementRuleByName();
            MovementRule rule = movementRule.GetRule(currentPiece.Name, currentPiece.Color);

            KeyValuePair<int, int> positionDifference = Board.CompareCells(initialPosition, finalPosition);

            bool isMoveEligible = rule.possibleMoves.Contains(positionDifference);

            if (Board.IsInBoundaries(finalPosition) && isMoveEligible)
            {
                Console.WriteLine($"before figure moved the cell {initialPosition} had figure {Board.boardCells[initialPosition]?.Name} of color {Board.boardCells[initialPosition]?.Color}");
                Console.WriteLine($"before figure moved the cell {finalPosition} had figure {Board.boardCells[finalPosition]?.Name} of color {Board.boardCells[finalPosition]?.Color}");
                Board.boardCells[initialPosition] = null;
                Board.boardCells[finalPosition] = currentPiece;

                Console.WriteLine($"after figure moved the cell {initialPosition} had figure {Board.boardCells[initialPosition]?.Name} of color {Board.boardCells[initialPosition]?.Color}");
                Console.WriteLine($"after figure moved the cell {finalPosition} had figure {Board.boardCells[finalPosition]?.Name} of color {Board.boardCells[finalPosition]?.Color}");
            }
            else
            {
                throw new ArgumentException("Chosen cell doesn't exist or move is not eligible");
            }
        }

        public bool IfCanMove(KeyValuePair<string, int> initialPosition, KeyValuePair<string, int> finalPositio)
        {
            return false;
        }
    }
}
