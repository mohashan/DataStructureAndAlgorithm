namespace Core
{
    public interface ISearch
    { 
        public int LinearSearch(int[] List, int Key);
        public List<int> HashTableSearch(int[] List, int Key);
    }
}