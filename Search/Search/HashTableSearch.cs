namespace Search
{
    public class HashTableSearch
    {
        public List<int> DoSearch(int[] List, int Key)
        {
            var hashTable = makeHashTable(List);
            int hash = Key.GetHashCode();
            if (hashTable.ContainsKey(hash))
            {
                return hashTable[hash];
            }
            return new List<int> { };
        }

        private Dictionary<int, List<int>> makeHashTable(int[] List)
        {
            Dictionary<int, List<int>> hashTable = new Dictionary<int, List<int>>();
            int hash = 0;
            for (int i = 0; i < List.Length; i++)
            {
                hash = List[i].GetHashCode();
                if (hashTable.ContainsKey(hash))
                {
                    hashTable[hash].Add(i);
                }
                else
                {
                    hashTable.Add(hash, new List<int> { i });
                }
            }
            return hashTable;
        }
    }

}
