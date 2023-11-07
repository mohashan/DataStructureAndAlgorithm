

int[] list = {23,12,48,1,25,14,56,19,12,41,31,28 };
int searchForExist = 19;
int searchForNotExist = 2;
int searchForDuplicate = 12;
var linearSearch = new LinearSearch.Search();

Console.WriteLine($"Linear Search for {searchForExist} in the list (Exist), Result : {linearSearch.DoSearch(list,searchForExist,0,list.Length)}");
Console.WriteLine($"Linear Search for {searchForNotExist} in the list (Not Exist), Result : {linearSearch.DoSearch(list,searchForNotExist,0,list.Length)}");
Console.WriteLine($"Linear Search for {searchForDuplicate} in the list (Duplicate), Result : {linearSearch.DoSearch(list,searchForDuplicate,0,list.Length)}");


Console.ReadLine();