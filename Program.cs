namespace HashTableAndBST
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Hash Table and BST");
            MyMapNode<string, string> hash = new MyMapNode<string, string>(6);
            hash.Add("0", "to");
            hash.Add("1", "be");
            hash.Add("2", "or");
            hash.Add("3", "not");
            hash.Add("4", "to");
            hash.Add("5", "be");
            string hash5 = hash.Get("5");
            string hash3 = hash.Get("3");

            Console.WriteLine("Value of key 5 is :" + " " + hash5);
            Console.WriteLine("Value of key 2 is :" + " " + hash3);
        }
    }
}
