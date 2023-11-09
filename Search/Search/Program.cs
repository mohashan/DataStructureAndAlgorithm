

using Search;

int[] list = {23,12,48,1,25,14,56,19,12,41,31,28 };
int searchForExist = 19;
int searchForNotExist = 2;
int searchForDuplicate = 12;
var linearSearch = new LinearSearch();
var hashTableSearch = new HashTableSearch();
var binarySearch = new BinarySearch();
var ternarySearch = new TernarySearch();
var jumpSearch = new JumpSearch();
var exponentialSearch = new ExponentialSearch();
var fibonacciSearch = new FibonacciSearch();
Console.WriteLine($"Linear Search for {searchForExist} in the list (Exist), Result : {linearSearch.DoSearch(list,searchForExist,0,list.Length)}");
Console.WriteLine($"Linear Search for {searchForNotExist} in the list (Not Exist), Result : {linearSearch.DoSearch(list,searchForNotExist, 0, list.Length)}");
Console.WriteLine($"Linear Search for {searchForDuplicate} in the list (Duplicate), Result : {linearSearch.DoSearch(list, searchForDuplicate, 0, list.Length)}");

Console.WriteLine();

Console.WriteLine($"HashTable Search for {searchForExist} in the list (Exist), Result : {hashTableSearch.DoSearch(list, searchForExist).IntList2String()}");
Console.WriteLine($"HashTable Search for {searchForNotExist} in the list (Not Exist), Result : {hashTableSearch.DoSearch(list, searchForNotExist).IntList2String()}");
Console.WriteLine($"HashTable Search for {searchForDuplicate} in the list (Duplicate), Result : {hashTableSearch.DoSearch(list, searchForDuplicate).IntList2String()}");

Console.WriteLine();
var sortedList = list.Order().ToArray();
Console.WriteLine($"Binary Search for {searchForExist} in the list (Exist), Result : {binarySearch.DoSearch(sortedList, searchForExist,0,sortedList.Length)}");
Console.WriteLine($"Binary Search for {searchForNotExist} in the list (Not Exist), Result : {binarySearch.DoSearch(sortedList, searchForNotExist, 0, sortedList.Length)}");
Console.WriteLine($"Binary Search for {searchForDuplicate} in the list (Duplicate), Result : {binarySearch.DoSearch(sortedList, searchForDuplicate, 0, sortedList.Length)}");

Console.WriteLine();

Console.WriteLine($"Ternary Search for {searchForExist} in the list (Exist), Result : {ternarySearch.DoSearch(sortedList, searchForExist, 0, sortedList.Length - 1)}");
Console.WriteLine($"Ternary Search for {searchForNotExist} in the list (Not Exist), Result : {ternarySearch.DoSearch(sortedList, searchForNotExist, 0, sortedList.Length - 1)}");
Console.WriteLine($"Ternary Search for {searchForDuplicate} in the list (Duplicate), Result : {ternarySearch.DoSearch(sortedList, searchForDuplicate, 0, sortedList.Length - 1)}");


Console.WriteLine();

Console.WriteLine($"Jump Search for {searchForExist} in the list (Exist), Result : {jumpSearch.DoSearch(sortedList, searchForExist, 0, sortedList.Length - 1)}");
Console.WriteLine($"Jump Search for {searchForNotExist} in the list (Not Exist), Result : {jumpSearch.DoSearch(sortedList, searchForNotExist, 0, sortedList.Length - 1)}");
Console.WriteLine($"Jump Search for {searchForDuplicate} in the list (Duplicate), Result : {jumpSearch.DoSearch(sortedList, searchForDuplicate, 0, sortedList.Length - 1)}");

Console.WriteLine();

Console.WriteLine($"Exponential Search for {searchForExist} in the list (Exist), Result : {exponentialSearch.DoSearch(sortedList, searchForExist, 0, sortedList.Length - 1)}");
Console.WriteLine($"Exponential Search for {searchForNotExist} in the list (Not Exist), Result : {exponentialSearch.DoSearch(sortedList, searchForNotExist, 0, sortedList.Length - 1)}");
Console.WriteLine($"Exponential Search for {searchForDuplicate} in the list (Duplicate), Result : {exponentialSearch.DoSearch(sortedList, searchForDuplicate, 0, sortedList.Length - 1)}");

Console.WriteLine();

Console.WriteLine($"Fibonacci Search for {searchForExist} in the list (Exist), Result : {fibonacciSearch.DoSearch(sortedList, searchForExist, 0, sortedList.Length - 1)}");
Console.WriteLine($"Fibonacci Search for {searchForNotExist} in the list (Not Exist), Result : {fibonacciSearch.DoSearch(sortedList, searchForNotExist, 0, sortedList.Length - 1)}");
Console.WriteLine($"Fibonacci Search for {searchForDuplicate} in the list (Duplicate), Result : {fibonacciSearch.DoSearch(sortedList, searchForDuplicate, 0, sortedList.Length - 1)}");


Console.ReadLine();