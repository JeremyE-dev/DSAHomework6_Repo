using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSAHomework6
{
    public class BinaryTree<T>
    {
        public class Node
        {
            internal BinaryTree<T> Owner { get; set; }
            public T Data { get; internal set; }
            public Node Left { get; internal set; }
            public Node Right { get; internal set; }
            public bool Leaf { get { return Left == null && Right == null; } }

            internal Node(BinaryTree<T> owner, T data)
            {
                Owner = owner;
                Data = data;
                Left = null;
                Right = null;
            }

            public Node InsertLeft(T data)
            {
                // Check preconditions
                if (Left != null)
                {
                    throw new InvalidOperationException("Left child already exists");
                }

                // Insert child node
                Left = new Node(Owner, data);
                ++Owner.Size;

                return Left;
            }

            public Node InsertRight(T data)
            {
                // Check preconditions
                if (Right != null)
                {
                    throw new InvalidOperationException("Right child already exists");
                }

                // Insert child node
                Right = new Node(Owner, data);
                ++Owner.Size;

                return Right;
            }

            public T RemoveLeft()
            {
                // Check preconditions
                if (Left == null)
                {
                    throw new InvalidOperationException("Left child does not exist");
                }
                if (!Left.Leaf)
                {
                    throw new InvalidOperationException("Left child is not a leaf");
                }

                var data = Left.Data;
                Left = null;
                --Owner.Size;

                return data;
            }

            public T RemoveRight()
            {
                // Check preconditions
                if (Right == null)
                {
                    throw new InvalidOperationException("Right child does not exist");
                }
                if (!Right.Leaf)
                {
                    throw new InvalidOperationException("Right child is not a leaf");
                }

                var data = Right.Data;
                Right = null;
                --Owner.Size;

                return data;
            }
        }

        public Node Root { get; private set; }
        public int Size { get; private set; }
        public bool Empty { get { return Size == 0; } }

        public Node InsertRoot(T data)
        {
            // Check pre-conditions
            if (!Empty)
            {
                throw new InvalidOperationException("Root already exists");
            }

            Root = new Node(this, data);
            ++Size;

            return Root;
        }

        public T RemoveRoot()
        {
            // Check preconditions
            if (Root == null)
            {
                throw new InvalidOperationException("Root does not exist");
            }
            if (!Root.Leaf)
            {
                throw new InvalidOperationException("Root is not a leaf");
            }

            var data = Root.Data;
            Root = null;
            --Size;

            return data; ;
        }
    }
}
