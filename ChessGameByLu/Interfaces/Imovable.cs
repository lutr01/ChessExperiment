using System.Collections.Generic;

namespace ChessGameByLu.Interfaces
{
    public interface IMovable
    {
        void Move(KeyValuePair<string, int> initialPosition , KeyValuePair<string, int> finalPosition);
        bool IfCanMove(KeyValuePair<string, int> initialPosition , KeyValuePair<string, int> finalPosition);
    }
}
