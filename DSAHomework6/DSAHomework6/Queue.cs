using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSAHomework6
{
    public class Queue<T>
    {
        private SinglyLinkedList<T> elems = new SinglyLinkedList<T>();

        public int Size
        {
            get { return elems.Size; }
        }

        public bool Empty
        {
            get { return elems.Empty; }
        }

        public void Enqueue(T data)
        {
            elems.InsertAfter(elems.Tail, data);
        }

        public T Dequeue()
        {
            if (elems.Empty)
            {
                throw new InvalidOperationException("Cannot view front of empty queue");
            }

            return elems.RemoveAfter(null);
        }

        public T Front
        {
            get
            {
                if (elems.Empty)
                {
                    throw new InvalidOperationException("Cannot peek at empty queue");
                }

                return elems.Head.Data;
            }
        }
    }
}
