using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Search;

public class ExponentialSearch
{
    public int DoSearch(int[] List, int Key, int Start, int End)
    {
        if (End < 0 || End < Start || End > List.Length || List.Length == 0 || Key > List[End] || Key < List[Start])
            return -1;

        if (List[Start] == Key)
            return 0;

        var reverseExp = ExponentialTheList(List, Key, Start, End);

        if (List[reverseExp] == Key)
            return reverseExp;

        var firstIndex = Start + (reverseExp / 2);
        var secondIndex = Start + reverseExp;

        BinarySearch bs = new BinarySearch();
        return bs.DoSearch(List, Key, firstIndex + 1, secondIndex - 1);
    }

    private int ExponentialTheList(int[] List, int Key, int Start, int End)
    {
        int span = End - Start;
        int i;
        for (i = 1; i <= span; i = i * 2)
        {
            if (List[Start + i] >= Key)
                return i;
        }

        return i;
    }
}
