using System.Collections.Generic;

namespace ChessGameByLu.MovementRules
{
    public abstract class MovementRule
    {
        public List<KeyValuePair<int,int>> possibleMoves;
        public bool isOneMoveAllowed;
        public List<KeyValuePair<int, int>> possibleEatingMoves;
        
    }
}
