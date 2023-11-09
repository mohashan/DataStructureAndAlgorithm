using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Search;

public class FibonacciSearch
{
    private int[] Fib;
    public int DoSearch(int[] List, int Key, int Start, int End)
    {
        Fib = CalculateFibSerie(List.Length);

        return FibTheList(List, Key, Fib.Length - 1,-1);
    }

    private int FibTheList(int[] List,int Key, int FibIndex, int StartIndex)
    {
        if (FibIndex < 2)
            return -1;

        var index = Math.Min(List.Length - 1, (StartIndex + Fib[FibIndex - 2]));
        if (List[index] == Key) 
            return index;

        if (List[index] > Key)
        {
            return FibTheList(List, Key, FibIndex - 2, StartIndex);
        }
        else
        {
            return FibTheList(List, Key, FibIndex - 1, index);
        }
    }

    private int[] CalculateFibSerie(int n)
    {
        List<int> result = new List<int>() { 0, 1 };
        int i = 1;
        while(result.Last() < n)
        {
            result.Add(result[i-1] + result[i]);
            i++;
        }
        return result.ToArray();
    }
}
