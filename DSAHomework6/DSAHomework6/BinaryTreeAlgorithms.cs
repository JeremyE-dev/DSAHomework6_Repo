using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSAHomework6
{
    public interface Visitor<T>
    {
        void Visit(T data);
    }

    public static class BinaryTreeAlgorithms
    {
        #region TraversePreOrder
        // Extension method
        public static void TraversePreOrder<T>(
            this BinaryTree<T> tree,
            Visitor<T> visitor)
        {
            TraversePreOrderRecursive(tree.Root, visitor);
        }

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
        #endregion

        #region TraverseInOrder
        // Extension method
        public static void TraverseInOrder<T>(
            this BinaryTree<T> tree,
            Visitor<T> visitor)
        {
            TraverseInOrderRecursive(tree.Root, visitor);
        }

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
        #endregion

        #region TraversePostOrder
        // Extension method
        public static void TraversePostOrder<T>(
            this BinaryTree<T> tree,
            Visitor<T> visitor)
        {
            TraversePostOrderRecursive(tree.Root, visitor);
        }

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
        #endregion

        #region TraverseLevelOrder
        // Extension method
        public static void TraverseLevelOrder<T>(
            this BinaryTree<T> tree,
            Visitor<T> visitor)
        {
            // Pre-conditions
            if (tree.Empty)
            {
                return;
            }

            // Track the nodes discovered but not yet visited
            var discoveredNodes = new Queue<BinaryTree<T>.Node>();

            // Start off with root discovered
            discoveredNodes.Enqueue(tree.Root);

            // While discovered nodes remain to be visited
            while (!discoveredNodes.Empty)
            {
                // Visit next discovered node
                var node = discoveredNodes.Dequeue();
                visitor.Visit(node.Data);

                // Add node's children to discovered node queue
                if (node.Left != null)
                {
                    discoveredNodes.Enqueue(node.Left);
                }
                if (node.Right != null)
                {
                    discoveredNodes.Enqueue(node.Right);
                }
            }
        }
        #endregion
    }
}
