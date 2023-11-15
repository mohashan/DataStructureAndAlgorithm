using Sort;
var bubbleSort = new BubbleSort();
var insertionSort = new InsertionSort();
var selectionSort = new SelectionSort();
var quickSort = new QuickSort();

int[] list = { 23, 12, 48, 1, 25, 14, 56, 19, 12, 41, 31, 28 };

Console.WriteLine($"Unsorted Array : {list.IntArray2String()}");

Console.WriteLine($"Bubble Sort : {bubbleSort.DoSort(list.OrderBy(c => Guid.NewGuid()).ToArray()).IntArray2String()}");
Console.WriteLine($"Insertion Sort : {insertionSort.DoSort(list.OrderBy(c => Guid.NewGuid()).ToArray()).IntArray2String()}");
Console.WriteLine($"Selection Sort : {selectionSort.DoSort(list.OrderBy(c => Guid.NewGuid()).ToArray()).IntArray2String()}");
list = new int[] { 19, 12, 12, 14, 1, 31, 25, 23, 48, 41, 56, 28 };
Console.WriteLine($"Quick Sort : {quickSort.DoSort(list).IntArray2String()}");

Console.ReadLine();