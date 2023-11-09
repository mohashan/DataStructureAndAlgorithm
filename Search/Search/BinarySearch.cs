namespace Search
{
    public class BinarySearch
    {
        public int DoSearch(int[] List, int Key, int Start, int End)
        {
            if (End < 0 || End < Start || End > List.Length || List.Length == 0)
                return -1;

            int middleIndex = (End + Start) / 2;
            int middleValue = List[middleIndex];

            // Right to the point
            if (middleValue == Key)
                return middleIndex;

            // Left Branch
            if (middleValue > Key)
            {
                return DoSearch(List, Key, Start, middleIndex - 1);
            }

            // Right Branch
            return DoSearch(List, Key, middleIndex + 1, End);


        }

    }
}