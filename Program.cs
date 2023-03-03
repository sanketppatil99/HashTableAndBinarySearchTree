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
            hash.Add("16", "avoidable");
            hash.Add("17", "situations");

            hash.Remove("5");
            hash.Remove("16");
            string hash10 = hash.Get("10");
            string hash5 = hash.Get("5");
            string hash16 = hash.Get("16");
            Console.WriteLine("10th index value is :" + hash10);
            Console.WriteLine("5th index value is :" + hash5);
            Console.WriteLine("16th index value is :" + hash16);

        }
    }
}
