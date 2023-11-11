using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sort;

public class InsertionSort
{
    public int[] DoSort(int[] List)
    {
        int swap, correctIndex;

        for (int i = 1; i < List.Length; i++)
        {
            swap = List[i];
            correctIndex = i;
            for (int j = i-1;j>=0;j--)
            {
                if (swap < List[j]) 
                {
                    List[j+1] = List[j];
                    correctIndex = j;
                }
                else
                {
                    continue;
                }
            }
            List[correctIndex] = swap;
        }
        return List;
    }
}
