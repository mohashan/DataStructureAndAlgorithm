using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Search;

public class JumpSearch
{

    public int DoSearch(int[] List, int Key, int Start, int End)
    {

        if (End < 0 || End < Start || End > List.Length || List.Length == 0 || Key > List[End] || Key < List[Start])
            return -1;

        var stepSize = Convert.ToInt32(Math.Sqrt(List.Length));

        var reversePoint = JumpTheList(List, Key, Start, End,stepSize);
        if(List[reversePoint] == Key)
            return reversePoint;

        if(reversePoint == End)
            stepSize = List.Length - Convert.ToInt32(Math.Pow(2, stepSize));

        LinearSearch ls = new LinearSearch();

        return ls.DoSearch(List, Key, reversePoint - stepSize + 1, reversePoint - 1);

    }

    public int JumpTheList(int[] List, int Key, int Start, int End,int StepSize)
    {

        for (int i = Start; i <= End; i = i + StepSize)
        {
            if (List[i] >= Key)
                return i;
        }

        return End;
    }
}
