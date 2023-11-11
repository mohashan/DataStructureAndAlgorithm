using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Search;

public class InterpolationSearch
{
    public int DoSearch(int[] List, int Key, int Start, int End)
    {
        if (End < 0 || End < Start || End > List.Length || List.Length == 0 || Key > List[End] || Key < List[Start])
            return -1;

        if (List[End] == List[Start])
        {
            if (List[Start] == Key)
                return Start;
            else
                return -1;
        }
        var expectedIndex = Start + (int)(((double)(Key - List[Start]) / (double)(List[End] - List[Start])) * (End - Start));

        if (List[expectedIndex] == Key)
        {
            return expectedIndex;
        }

        if (List[expectedIndex] > Key)
        {
            return DoSearch(List, Key, Start, expectedIndex - 1);
        }

        if (List[expectedIndex] < Key)
        {
            return DoSearch(List, Key, expectedIndex + 1, End);
        }
        return -1;
    }
}
