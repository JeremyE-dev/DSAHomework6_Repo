using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSAHomework6
{
 
    public class PrintVisitor<T> : Visitor<T>
    {
        public void Visit(T data)
        {
            Console.WriteLine(data);
        }
    }

    class Homework6
    {
        //a.) returns number of leaf nodes in the tree
        //public static int CountLeaves(BinaryTree tree)
        //{

        //}

        // b.) Returns number of non-leaf nodes in the tree
        // public static int CountNonLeaves(BinaryTree tree)

        // c.) Returns the height of the tree
        // public static int Height(BinaryTree tree)

        // d.) Prints the elements of the tree using a pre-order traversal
        public static void PrintPreOrder(BinaryTree<int> tree)
        {
            PrintVisitor<int> visitor = new PrintVisitor<int>();
            tree.TraversePreOrder(visitor);

        }

        // e.) Prints the elements of the tree using a in-order traversal
        // public static void PrintInOrder(BinaryTree tree)

        // f.) Prints the elements of the tree using a post-order traversal`
        // public static void PrintPostOrder(BinaryTree tree)

        // g.) Removes	all	leaf	nodes	from	the	tree. Use	PrintPreOrder,	
        // PrintInOrder,	or PrintPostOrder  after calling RemoveLeaves to  show
        // that RemoveLeaves successfully    removed all leaves.

        // public static void RemoveLeaves(BinaryTree tree)


        // Helpers

        // traverse preorder
        private static void TraversePreOrderRecursive<T>(
            BinaryTree<T>.Node node,
            Visitor<T> visitor)
        {
            if (node == null)
            {
                return;
            }
            visitor.Visit(node.Data);
            TraversePreOrderRecursive(node.Left, visitor);
            TraversePreOrderRecursive(node.Right, visitor);
        }

    }
}
