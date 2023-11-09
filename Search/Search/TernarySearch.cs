using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Search
{
    public class TernarySearch
    {
        public int DoSearch(int[] List, int Key, int Start, int End)
        {
            if (End < 0 || End < Start || End > List.Length || List.Length == 0)
                return -1;

            int First = Start + ((End - Start) / 3);
            int Second = First + ((End - Start) / 3);

            if (List[First] == Key)
                return First;

            if (List[Second] == Key)
                return Second;

            if (List[First] > Key)
            {
                return DoSearch(List, Key, Start, First - 1);
            }

            if (List[Second] > Key)
            {
                return DoSearch(List, Key, First + 1, Second - 1);
            }

            return DoSearch(List, Key, Second + 1, End);

        }
    }
}
