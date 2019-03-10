using System;
using System.Collections.Generic;

namespace ChessGameByLu.MovementRules
{
    /// <summary>
    /// holds the movement rule for specific chess piece
    /// </summary>
    public class MovementRuleByName
    {
        public Dictionary<string, MovementRule> rule = new Dictionary<string, MovementRule>()
        {
            {"knight", new KnightMovementRule() },
            {"bishop", new BishopMovementRule() },
            {"king", new KingMovementRule() },
            {"queen", new QueenMovementRule() },
            {"pawn", new PawnMovementRule() },
            {"rook", new RookMovementRule() }
        };
        /// <summary>
        /// returns the movement rule for specific chess piece
        /// </summary>
        /// <param name="name">chess piece name</param>
        /// <returns>returns the movement rule</returns>
        public MovementRule GetRule(string name)
        {
            if (rule.ContainsKey(name))
            {
                return rule[name];
            }
            else
            {
                throw new ArgumentException("figure name was not found in the dictionary");
            }
        }
    }
}
