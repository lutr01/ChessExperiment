using System.Collections.Generic;

namespace ChessGameByLu.MovementRules
{
    /// <summary>
    /// describes the possible move difference of columns and rows coordinates for Knight
    /// </summary>
    public class KnightMovementRule : MovementRule
    {
        public KnightMovementRule()
        {
            List<KeyValuePair<int, int>> tabl = new List<KeyValuePair<int, int>>
            {
                new KeyValuePair<int, int>(2, 1),
                new KeyValuePair<int, int>(2, -1),
                new KeyValuePair<int, int>(1, -2),
                new KeyValuePair<int, int>(-1, -2),
                new KeyValuePair<int, int>(-2, -1),
                new KeyValuePair<int, int>(-2, 1),
                new KeyValuePair<int, int>(-1, 2),
                new KeyValuePair<int, int>(1, 2)
            };

            possibleMoves = tabl; 

            isOneMoveAllowed = true;

            possibleEatingMoves = possibleMoves;
        }
    }
}
