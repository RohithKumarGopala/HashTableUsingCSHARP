namespace HashTableUsingCSHARP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HashTable<string> hashTable = new HashTable<string>(8);

            hashTable.AddOperation("Rohith");
            hashTable.AddOperation("Rahul");
            hashTable.AddOperation("Shoban");
            hashTable.AddOperation("Vishnu");
            hashTable.AddOperation("Prathuysha");

            //hashTable.DisplayOperation();
            hashTable.SearchOperation("Shoban");
        }
    }
}