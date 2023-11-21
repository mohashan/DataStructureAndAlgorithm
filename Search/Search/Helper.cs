using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Search;

public static class Helper
{
    public static string IntArray2String(this int[] list)
    {
        StringBuilder sb = new StringBuilder();
        foreach (int i in list)
        {
            sb.Append(i.ToString());
            sb.Append(", ");
        }
        return sb.ToString();
    }

    public static int[] Swap(this int[] List, int Index1, int Index2)
    {
        int swap = List[Index1];
        List[Index1] = List[Index2];
        List[Index2] = swap;
        return List;
    }
}
