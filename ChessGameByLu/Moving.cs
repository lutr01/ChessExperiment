using ChessGameByLu.MovementRules;
using ChessGameByLu.Pieces;
using System;
using System.Collections.Generic;

namespace ChessGameByLu
{
    /// <summary>
    /// describes the moving options of the pieces
    /// </summary>
    public class Moving
    {
        /// <summary>
        /// checks if the piece can move to the specified cell and moves it if yes
        /// </summary>
        /// <param name="initialPosition">starting cell</param>
        /// <param name="finalPosition">finishing cell</param>
        public void Move(KeyValuePair<string, int> initialPosition, KeyValuePair<string, int> finalPosition)
        {
            ChessPiece currentPiece = Board.boardCells[initialPosition];

            MovementRuleByName movementRule = new MovementRuleByName();
            MovementRule rule = movementRule.GetRule(currentPiece.Name, currentPiece.Color);

            KeyValuePair<int, int> positionDifference = Board.CompareCells(initialPosition, finalPosition);

            bool isMoveEligible = rule.possibleMoves.Contains(positionDifference);

            if (Board.IsInBoundaries(finalPosition) && isMoveEligible)
            {
                Board.UpdatePosition(initialPosition, finalPosition);
            }
            else
            {
                throw new ArgumentException("Chosen cell doesn't exist or move is not eligible");
            }
        }
        /// <summary>
        /// checks if there are pieces on the way or if the final cell is not occupied by same color piece
        /// </summary>
        /// <param name="initialPosition">starting cell</param>
        /// <param name="finalPositio">final cell</param>
        /// <returns></returns>
        public bool IfCanMove(KeyValuePair<string, int> initialPosition, KeyValuePair<string, int> finalPositio)
        {
            return false;
        }
    }
}
