using System.Collections.Generic;

namespace ChessGameByLu.MovementRules
{
    /// <summary>
    /// describes the possible move difference of columns and rows coordinates
    /// </summary>
    public abstract class MovementRule
    {
        public List<KeyValuePair<int,int>> possibleMoves;
        public bool isOneMoveAllowed;
        public List<KeyValuePair<int, int>> possibleEatingMoves;
        
    }
}
