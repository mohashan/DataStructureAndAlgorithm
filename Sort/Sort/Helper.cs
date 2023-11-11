using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sort;

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
}
