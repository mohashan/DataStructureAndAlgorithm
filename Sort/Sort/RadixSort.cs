using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sort;

public class RadixSort
{
    public int[] DoSort(int[] list)
    {
        int maxNum = list.Max();
        List<int> result = new List<int>(list);
        // Get the digit counts of max number
        int digitCount = (int)Math.Floor(Math.Log10(maxNum) + 1);
        List<int>[] queue;
        for (int i = 1;i <= digitCount; i++)
        {
            queue = Enqueue(result,i);

            result = new List<int>();
            foreach (var item in queue)
            {
                if(item != null) 
                    result.AddRange(item);
            }
        }

        return result.ToArray();
    }
    private List<int>[] Enqueue(List<int> list,int sortLevel)
    {
        int loc;
        var queue = new List<int>[10];
        foreach (var item in list)
        {
            loc = (item / (int)Math.Pow(10, sortLevel - 1)) % 10;

            if (queue[loc] == null)
                queue[loc] = new List<int>();

            queue[loc].Add(item);
        }
        return queue;
    }
}
