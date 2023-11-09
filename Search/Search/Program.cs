

using Search;

int[] list = {23,12,48,1,25,14,56,19,12,41,31,28 };
int searchForExist = 19;
int searchForNotExist = 2;
int searchForDuplicate = 12;
var linearSearch = new LinearSearch.Search();
var hashTableSearch = new HashTable.Search();
var binarySearch = new BinarySearch.Search();

Console.WriteLine($"Linear Search for {searchForExist} in the list (Exist), Result : {linearSearch.DoSearch(list,searchForExist)}");
Console.WriteLine($"Linear Search for {searchForNotExist} in the list (Not Exist), Result : {linearSearch.DoSearch(list,searchForNotExist)}");
Console.WriteLine($"Linear Search for {searchForDuplicate} in the list (Duplicate), Result : {linearSearch.DoSearch(list, searchForDuplicate)}");

Console.WriteLine();

Console.WriteLine($"HashTable Search for {searchForExist} in the list (Exist), Result : {hashTableSearch.DoSearch(list, searchForExist).IntList2String()}");
Console.WriteLine($"HashTable Search for {searchForNotExist} in the list (Not Exist), Result : {hashTableSearch.DoSearch(list, searchForNotExist).IntList2String()}");
Console.WriteLine($"HashTable Search for {searchForDuplicate} in the list (Duplicate), Result : {hashTableSearch.DoSearch(list, searchForDuplicate).IntList2String()}");

Console.WriteLine();
var sortedList = list.Order().ToArray();
Console.WriteLine($"Binary Search for {searchForExist} in the list (Exist), Result : {binarySearch.DoSearch(sortedList, searchForExist,0,sortedList.Length)}");
Console.WriteLine($"Binary Search for {searchForNotExist} in the list (Not Exist), Result : {binarySearch.DoSearch(sortedList, searchForNotExist, 0, sortedList.Length)}");
Console.WriteLine($"Binary Search for {searchForDuplicate} in the list (Duplicate), Result : {binarySearch.DoSearch(sortedList, searchForDuplicate, 0, sortedList.Length)}");


Console.ReadLine();