namespace HashTableAndBST
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Hash Table and BST");
            HashTableAndBST.BinarySearchTree<int> tree = new HashTableAndBST.BinarySearchTree<int>(56);
            tree.AddNode(30);
            tree.AddNode(70);
            tree.Display();
        }
    }
}
