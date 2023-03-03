namespace HashTableAndBST
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Hash Table and BST");
            MyMapNode<string, string> hash = new MyMapNode<string, string>(6);
            hash.Add("0", "Paranoid");
            hash.Add("1", "are");
            hash.Add("2", "not");
            hash.Add("3", "paranoid");
            hash.Add("4", "because");
            hash.Add("5", "they");
            hash.Add("6", "are");
            hash.Add("7", "paranoid");
            hash.Add("8", "but");
            hash.Add("9", "because");
            hash.Add("10", "they");
            hash.Add("11", "keep");
            hash.Add("12", "themselves");
            hash.Add("13", "deleberately");
            hash.Add("14", "into");
            hash.Add("15", "paranoid");
            hash.Add("5", "avoidable");
            hash.Add("5", "situations");
            string hash5 = hash.Get("5");
            string hash3 = hash.Get("3");
            string hash12 = hash.Get("12");
            string hash8 = hash.Get("8");

            Console.WriteLine("Value of key 5 is :" + " " + hash5);
            Console.WriteLine("Value of key 3 is :" + " " + hash3);
            Console.WriteLine("Value of key 12 is :" + " " + hash12);
            Console.WriteLine("Value of key 8 is :" + " " + hash8);
        }
    }
}
