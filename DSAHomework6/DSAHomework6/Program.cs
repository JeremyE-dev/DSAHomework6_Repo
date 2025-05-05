using System.Security.AccessControl;

namespace DSAHomework6
{
    internal class Program
    {
        static void Main(string[] args)
        {
                          
            BinaryTree<int> tree1 = new BinaryTree<int>();
            // Root
            var t1_root = tree1.InsertRoot(1);

            // Left subtree of root
            var t1_node2 = t1_root.InsertLeft(2);
            var t1_node4 = t1_node2.InsertLeft(4);
            var t1_node7 = t1_node4.InsertLeft(7);

            // Right subtree of root
            var t1_node3 = t1_root.InsertRight(3);
            var t1_node5 = t1_node3.InsertLeft(5);
            var t1_node6 = t1_node3.InsertRight(6);
            var t1_node8 = t1_node6.InsertRight(8);
            var t1_node9 = t1_node8.InsertRight(9);

            // Print tree1 using pre-order traversal
            Console.WriteLine();
            Console.WriteLine("Tree 1 Pre-order");
            Console.WriteLine("_________________________");
            Homework6.PrintPreOrder(tree1);

            // Create a second binary tree
            BinaryTree<int> tree2 = new BinaryTree<int>();
       
            // Root is 6
            var t2_root = tree2.InsertRoot(6);

            // Left subtree
            var t2_node4 = t2_root.InsertLeft(4);
            var t2_node2 = t2_node4.InsertLeft(2);
            t2_node4.InsertRight(5);
            t2_node2.InsertLeft(1);
            t2_node2.InsertRight(3);

            // Right subtree
            var t2_node8 = t2_root.InsertRight(8);
            t2_node8.InsertLeft(7);
            t2_node8.InsertRight(9);

            // Print tree1 using pre-order traversal
            Console.WriteLine();
            Console.WriteLine("Tree 2 Pre-order");
            Console.WriteLine("_______________________________");
            Homework6.PrintPreOrder(tree2);

        }
    }
}
