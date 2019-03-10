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
            MovementRule rule = movementRule.GetRule(currentPiece.Name);

            KeyValuePair<int, int> positionDifference = Board.CompareCells(initialPosition, finalPosition);

            bool isMoveEligible = rule.possibleMoves.Contains(positionDifference);

            ChessPiece destinationPiece = Board.GetFigureAtCell(finalPosition);
            string colorOfPieceAtDestination = destinationPiece.Color;

            if (Board.IsInBoundaries(finalPosition) 
                && isMoveEligible 
                && colorOfPieceAtDestination.ToLower() != currentPiece.Color.ToLower())
            {
                Board.UpdatePosition(initialPosition, finalPosition);
            }
            else
            {
                throw new ArgumentException("Chosen cell doesn't exist, move is not eligible, or cell is occupied by same color piece");
            }
        }
        
    }
}
