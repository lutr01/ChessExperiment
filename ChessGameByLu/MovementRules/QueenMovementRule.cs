using System.Collections.Generic;

namespace ChessGameByLu.MovementRules
{
    public class QueenMovementRule : MovementRule
    {
        public QueenMovementRule()
        {
            List<KeyValuePair<int, int>> tabl = new List<KeyValuePair<int, int>>();
            tabl.Add(new KeyValuePair<int, int>(1, 0));
            tabl.Add(new KeyValuePair<int, int>(1, 1));
            tabl.Add(new KeyValuePair<int, int>(0, 1));
            tabl.Add(new KeyValuePair<int, int>(-1, 1));
            tabl.Add(new KeyValuePair<int, int>(-1, 0));
            tabl.Add(new KeyValuePair<int, int>(-1, -1));
            tabl.Add(new KeyValuePair<int, int>(0, -1));
            tabl.Add(new KeyValuePair<int, int>(1, -1));

            possibleMoves = tabl;

            isOneMoveAllowed = false;

            possibleEatingMoves = possibleMoves;
        }
    }
}
