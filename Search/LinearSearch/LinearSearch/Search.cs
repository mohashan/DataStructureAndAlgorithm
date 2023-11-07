
namespace LinearSearch
{
    public class Search
    {

        public int DoSearch(int[] List, int Key)
        {
            for (int i = 0; i < List.Length; i++)
            {
                if (List[i] == Key)
                    return i;
            }

            return -1;
        }
    }
}