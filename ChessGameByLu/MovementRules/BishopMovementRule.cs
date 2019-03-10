using System.Collections.Generic;

namespace ChessGameByLu.MovementRules
{
    /// <summary>
    /// describes the possible move difference of columns and rows coordinates for Bishop
    /// </summary>
    public class BishopMovementRule : MovementRule
    {
        public BishopMovementRule()
        {
            List<KeyValuePair<int, int>> tabl = new List<KeyValuePair<int, int>>();
            tabl.Add(new KeyValuePair<int, int>(1, 1));
            tabl.Add(new KeyValuePair<int, int>(-1, 1));
            tabl.Add(new KeyValuePair<int, int>(-1, -1));
            tabl.Add(new KeyValuePair<int, int>(1, -1));

            possibleMoves = tabl;

            isOneMoveAllowed = false;

            possibleEatingMoves = possibleMoves;
        }
    }
}
