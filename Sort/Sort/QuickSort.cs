namespace Sort;

public class QuickSort
{
    public int[] DoSort(int[] List)
    { 

        if (List.Length <= 1)
            return List;

        int swap;
        int pivotIndex = List.Length - 1;
        int pivotValue = List[pivotIndex];
        int LeftIndex = 0;
        int RightIndex = List.Length - 2;
        bool LeftTargeted = false,
            RightTargeted = false;
        while(true) 
        {
            if (List[LeftIndex] <= pivotValue && LeftIndex < List.Length)
            { 
                LeftIndex++;
            }
            else
            {
                LeftTargeted = true;
            }

            if (List[RightIndex] > pivotValue)
            {
                RightIndex--;
            }
            else
            {
                RightTargeted = true;
            }

            if (LeftIndex > RightIndex)
            {
                if(LeftIndex != pivotIndex)
                    Swap(List, LeftIndex, pivotIndex);

                var part1 = DoSort(List[..LeftIndex]);
                var part2 = DoSort(List[(LeftIndex + 1)..]);
                return part1.Concat(new int[] {pivotValue}).Concat(part2).ToArray();
            }
            if (LeftTargeted && RightTargeted)
            {
                if (List[LeftIndex] != List[RightIndex])
                {
                    Swap(List,LeftIndex,RightIndex);
                }
                LeftTargeted = false;
                RightTargeted = false;
            }
        } 
    }

    private int[] Swap(int[] List,int Index1,int Index2)
    {
        int swap = List[Index1];
        List[Index1] = List[Index2];
        List[Index2] = swap;
        return List;
    }
}