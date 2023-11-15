using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sort;

public class MergeSort
{
    public int[] DoSort(int[] List)
    {
        if (List.Length <= 1)
            return List;

        int MiddleIndex = List.Length / 2;

        var List1 = DoSort(List[..MiddleIndex]);
        var List2 = DoSort(List[MiddleIndex..]);

        int RightIndex = 0, LeftIndex = 0;

        for(int i=0; i < List.Length; i++)
        {
            if (LeftIndex == -1)
            {
                List[i] = List2[RightIndex];
                RightIndex++;
                if (RightIndex > (List2.Length - 1))
                    RightIndex = -1;
                continue;
            }

            if(RightIndex == -1)
            {
                List[i] = List1[LeftIndex];
                LeftIndex++;
                if (LeftIndex > (List1.Length - 1))
                    LeftIndex = -1;
                continue;
            }

            if (List1[LeftIndex] <= List2[RightIndex])
            {
                List[i] = List1[LeftIndex];
                LeftIndex++;
                if (LeftIndex > (List1.Length - 1))
                    LeftIndex = -1;
                continue;
            }
            else
            {
                List[i] = List2[RightIndex];
                RightIndex++;
                if (RightIndex > (List2.Length - 1))
                    RightIndex = -1;
                continue;
            }
        }

        return List;
    }
}
