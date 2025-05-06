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
        public static int CountLeaves(BinaryTree<int> tree)
        {
            return CountLeavesRecursive(tree.Root);
        }

        // b.) Returns number of non-leaf nodes in the tree
        public static int CountNonLeaves(BinaryTree<int> tree)
        {
            return CountNonLeavesRecursive(tree.Root);
        }

        // c.) Returns the height of the tree
        public static int Height(BinaryTree<int> tree)
        {
            if (tree == null)
            {
                throw new ArgumentNullException("the tree cannot be null");
            }

            return CountLevels(tree.Root) - 1;
        }

        // d.) Prints the elements of the tree using a pre-order traversal
        public static void PrintPreOrder(BinaryTree<int> tree)
        {
            if (tree.Empty)
            {
                throw new ArgumentNullException("the tree is Empty");
            }

            PrintVisitor<int> visitor = new PrintVisitor<int>();
            tree.TraversePreOrder(visitor);

        }

        // e.) Prints the elements of the tree using a in-order traversal
        // public static void PrintInOrder(BinaryTree tree)
        public static void PrintInOrder(BinaryTree<int> tree)
        {
            if (tree.Empty)
            {
                throw new ArgumentNullException("the tree is Empty");
            }

            PrintVisitor<int> visitor = new PrintVisitor<int>();
            tree.TraverseInOrder(visitor);

        }

        // f.) Prints the elements of the tree using a post-order traversal`
        // public static void PrintPostOrder(BinaryTree tree)
        public static void PrintPostOrder(BinaryTree<int> tree)
        {
            if (tree.Empty)
            {
                throw new ArgumentNullException("the tree is Empty");
            }

            PrintVisitor<int> visitor = new PrintVisitor<int>();
            tree.TraversePostOrder(visitor);
        }

        // g.) Removes	all	leaf	nodes	from	the	tree. Use PrintPreOrder,	
        // PrintInOrder, or PrintPostOrder after calling RemoveLeaves to  show
        // that RemoveLeaves successfully   removed all leaves.

        public static void RemoveLeaves(BinaryTree<int> tree)
        {

            while (!tree.Empty)
            {
                if (tree.Root.Leaf)
                {
                    Console.WriteLine($"Removing root leaf: {tree.Root.Data}");
                    tree.RemoveRoot();
                }
                else
                {
                    RemoveLeavesRecursive(tree.Root);
                }
            }
        }

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

        // traverse in order
        private static void TraverseInOrderRecursive<T>(
        BinaryTree<T>.Node node,
         Visitor<T> visitor)
        {
            if (node == null)
            {
                return;
            }

            TraverseInOrderRecursive(node.Left, visitor);
            visitor.Visit(node.Data);
            TraverseInOrderRecursive(node.Right, visitor);
        }

        // traverse post order
        private static void TraversePostOrderRecursive<T>(
                    BinaryTree<T>.Node node,
                    Visitor<T> visitor)
        {
            if (node == null)
            {
                return;
            }
            TraversePostOrderRecursive(node.Left, visitor);
            TraversePostOrderRecursive(node.Right, visitor);
            visitor.Visit(node.Data);
        }

        // count leaves
        private static int CountLeavesRecursive<T>(BinaryTree<T>.Node node)
        {
            if (node == null)
            {
                return 0;
            }
            if (node.Leaf)
            {
                return 1;
            }
            return CountLeavesRecursive(node.Left) + CountLeavesRecursive(node.Right);
        }

        // count non-leaves
        private static int CountNonLeavesRecursive<T>(BinaryTree<T>.Node node)
        {
            if (node == null)
            {
                return 0;
            }
            if (node.Leaf)
            {
                return 0;
            }
            return 1 + CountNonLeavesRecursive(node.Left) + CountNonLeavesRecursive(node.Right);
        }

        // count levels
        // returns the number of levels in the tree

        private static int CountLevels<T>(BinaryTree<T>.Node node)
        {
            if (node == null)
                return 0;

            int leftLevels = CountLevels(node.Left);
            int rightLevels = CountLevels(node.Right);

            return Math.Max(leftLevels, rightLevels) + 1;
        }

        private static void RemoveLeavesRecursive<T>(BinaryTree<T>.Node node)
        {
            if (node == null)
            {
                return;
            }

            // Check and remove left leaf
            if (node.Left != null && node.Left.Leaf)
            {
                Console.WriteLine($"Removing left leaf: {node.Left.Data}");
                node.RemoveLeft();
            }
            else
            {
                RemoveLeavesRecursive(node.Left);
            }

            // Check and remove right leaf
            if (node.Right != null && node.Right.Leaf)
            {
                Console.WriteLine($"Removing right leaf: {node.Right.Data}");
                node.RemoveRight();
            }
            else
            {
                RemoveLeavesRecursive(node.Right);
            }
        }

    }
}
