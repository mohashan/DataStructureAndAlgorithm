using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sort;

public class SelectionSort
{
    public int[] DoSort(int[] List)
    {
        int swap,index;
        for (int i = 0; i < List.Length - 1; i++)
        {
            swap = List[i];
            index = i;
            for (int j = i + 1; j < List.Length; j++)
            {
                if (List[j] < swap)
                {
                    swap = List[j];
                    index = j;
                }
            }
            if(index != i)
            {
                List[index] = List[i];
                List[i] = swap;
            }
        }
        return List;
    }
}
