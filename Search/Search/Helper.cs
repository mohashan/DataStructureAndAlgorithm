using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Search
{
    public static class Helper
    {
        public static string IntList2String(this List<int> list)
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
}
