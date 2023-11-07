using Core;

namespace LinearSearch
{
    public class Search : ISearchInfrastructure
    {

        public int DoSearch(int[] List, int Key, int Start, int End)
        {
            for (int i = Start; i < End; i++)
            {
                if (List[i] == Key)
                    return i;
            }

            return -1;
        }
    }
}