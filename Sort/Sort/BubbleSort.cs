using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sort;

public class BubbleSort
{
    public int[] DoSort(int[] List)
    {
        int swap;
        bool swapped;
        do
        {
            swapped = false;
            for (int i = 0; i < List.Length - 1; i++)
            {
                if (List[i] > List[i + 1])
                {
                    swap = List[i];
                    List[i] = List[i + 1];
                    List[i + 1] = swap;
                    swapped = true;
                }
            }
        } while (swapped);
        
        return List;
    }
}
