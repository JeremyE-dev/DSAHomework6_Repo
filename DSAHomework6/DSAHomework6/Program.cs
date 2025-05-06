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


            // Print the count of leaves for tree 1
            Console.WriteLine("Tree 1 Leaf Count: " + Homework6.CountLeaves(tree1));
            Console.WriteLine("_______________________________");
            Console.WriteLine();

            // Print the count of non-leaf nodes for tree 1
            Console.WriteLine("Tree 1 Non-Leaf Count: " + Homework6.CountNonLeaves(tree1));
            Console.WriteLine("_______________________________");
            Console.WriteLine();

            // Print the height of tree 1
            Console.WriteLine("Tree 1 Height: " + Homework6.Height(tree1));
            Console.WriteLine("_______________________________");
            Console.WriteLine();

            // Print tree1 using pre-order traversal
            Console.WriteLine();
            Console.WriteLine("Tree 1 Pre-order");
            Console.WriteLine("_________________________");
            Homework6.PrintPreOrder(tree1);

            // Print tree1 using in-order traversal
            Console.WriteLine();
            Console.WriteLine("Tree 1 In-order");
            Console.WriteLine("_________________________");
            Homework6.PrintInOrder(tree1);

            // Print tree1 using post-order traversal
            Console.WriteLine();
            Console.WriteLine("Tree 1 Post-order");
            Console.WriteLine("_________________________");
            Homework6.PrintPostOrder(tree1);
            Console.WriteLine();

            // Remove all leaves from tree1
            Homework6.RemoveLeaves(tree1);
            Console.WriteLine();

            // Print tree1 using pre-order traversal
            Console.WriteLine();
            Console.WriteLine("Verify Tree 1 is empty");
            Console.WriteLine("_________________________");

            try 
            {
                Homework6.PrintPreOrder(tree1);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
                Console.WriteLine();
            }
          


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

            // Print the count of leaves for tree 2
            Console.WriteLine("Tree 2 Leaf Count: " + Homework6.CountLeaves(tree2));
            Console.WriteLine("_______________________________");
            Console.WriteLine();

            // Print the count of non-leaf nodes for tree 2
            Console.WriteLine("Tree 2 Non-Leaf Count: " + Homework6.CountNonLeaves(tree2));
            Console.WriteLine("_______________________________");
            Console.WriteLine();

            // Print the height of tree 2
            Console.WriteLine("Tree 2 Height: " + Homework6.Height(tree2));
            Console.WriteLine("_______________________________");
            Console.WriteLine();

            // Print tree2 using pre-order traversal
            Console.WriteLine();
            Console.WriteLine("Tree 2 Pre-order");
            Console.WriteLine("_______________________________");
            Homework6.PrintPreOrder(tree2);

            // Print tree2 using in-order traversal
            Console.WriteLine();
            Console.WriteLine("Tree 2 In-order");
            Console.WriteLine("_______________________________");
            Homework6.PrintInOrder(tree2);

            // Print tree2 using pre-order traversal
            Console.WriteLine();
            Console.WriteLine("Tree 2 Post-order");
            Console.WriteLine("_______________________________");
            Homework6.PrintPostOrder(tree2);
            Console.WriteLine();

            // Remove all leaves from tree2
            Homework6.RemoveLeaves(tree2);
            Console.WriteLine();

            // Print tree2 using pre-order traversal
            Console.WriteLine();
            Console.WriteLine("Verify Tree 2 is empty");
            Console.WriteLine("_________________________");

            try
            {
                Homework6.PrintPreOrder(tree2);
                Console.WriteLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
                Console.WriteLine();
            }


        }
    }
}
