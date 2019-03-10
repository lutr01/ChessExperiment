//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace ChessGameByLu.Helpers
//{
//    public static class KeyValuePairExtensions
//    {
//        public static bool IfKeyValuePairExists(List<KeyValuePair<int, int>> dictionary, KeyValuePair<int, int> keyValuePair)
//        {
//            var lookup = dictionary.ToLookup(kvp => kvp.Key, kvp => kvp.Value);

//            foreach (int x in lookup[keyValuePair.Key])
//            {
                
//                if (dictionary.Contains(keyValuePair))
//                {
//                    return true;
//                }
//            }

//            return false;
//        }
//    }
//}
