using Sort;
var bubbleSort = new BubbleSort();
var insertionSort = new InsertionSort();

int[] list = { 23, 12, 48, 1, 25, 14, 56, 19, 12, 41, 31, 28 };

Console.WriteLine($"Unsorted Array : {list.IntArray2String()}");

Console.WriteLine($"Bubble Sort : {bubbleSort.DoSort(list.OrderBy(c => Guid.NewGuid()).ToArray()).IntArray2String()}");
Console.WriteLine($"Insertion Sort : {insertionSort.DoSort(list.OrderBy(c=>Guid.NewGuid()).ToArray()).IntArray2String()}");

Console.ReadLine();