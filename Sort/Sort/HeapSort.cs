using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sort;

public class HeapSort
{
    public int[] DoSort(int[] List)
    {
        for (int i = List.Length; i > 1 ; i--)
        {
            List = Heaping(List[..i]).Concat(List[i..]).ToArray();
            List.Swap(0, i - 1);
        }
        return List;
    }

    private int[] Heaping(int[] List)
    {
        int i = (List.Length / 2) - 1;
        for (; i >= 0; i--)
        {
            int lIndex = (2 * i) + 1;
            int rIndex = lIndex + 1;

            if (lIndex < List.Length && List[i] < List[lIndex])
                List.Swap(lIndex, i);

            if (rIndex < List.Length && List[i] < List[rIndex])
                List.Swap(rIndex, i);
        }
        return List;
    }
}
