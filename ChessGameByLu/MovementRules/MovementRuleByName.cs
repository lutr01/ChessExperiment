using System;
using System.Collections.Generic;

namespace ChessGameByLu.MovementRules
{
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

        public MovementRule GetRule(string name, string color)
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
