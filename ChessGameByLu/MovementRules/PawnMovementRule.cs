using System.Collections.Generic;

namespace ChessGameByLu.MovementRules
{
    public class PawnMovementRule : MovementRule
    {
        public PawnMovementRule()
        {
            List<KeyValuePair<int, int>> tabl = new List<KeyValuePair<int, int>>
            {
                new KeyValuePair<int, int>(1, 0),
                new KeyValuePair<int, int>(2, 0)
            };

            possibleMoves = tabl;

            isOneMoveAllowed = true;

            List<KeyValuePair<int, int>> tableat = new List<KeyValuePair<int, int>>
            {
                new KeyValuePair<int, int>(1, 1),
                new KeyValuePair<int, int>(1, -1)
            };

            possibleEatingMoves = tableat;
        }
    }
}
