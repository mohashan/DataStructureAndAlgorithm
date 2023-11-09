using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Search
{
    public class LinearSearch
    {

        public int DoSearch(int[] List, int Key,int Start, int End)
        {
            if (End < 0 || End < Start || End > List.Length || List.Length == 0)
                return -1;

            for (int i = Start; i < End; i++)
            {
                if (List[i] == Key)
                    return i;
            }

            return -1;
        }
    }
}