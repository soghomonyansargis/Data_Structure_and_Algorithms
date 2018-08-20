using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLinkedListOk
{
    class LinkedList<T> :IEnumerable<T>
    {
        public LinkedListNode<T> head;
        public LinkedListNode<T> tail;
        public int Count { get; private set; }
        //---------------------------------------------
        public void AddLast(T data)
        {
            LinkedListNode<T> node = new LinkedListNode<T>(data);
            if (Count == 0)
            {
                head = node;
            }
            else
            {
                tail.Next = node;
                node.Previous = tail;
            }
            tail = node;
            Count++;
        }
        public void AddFirst(T data)
        {
            LinkedListNode<T> node = new LinkedListNode<T>(data);
            LinkedListNode<T> temp = head;
            head = node;
            head.Next = temp;
            if (Count==0)
            {
                tail = head;
            }
            else
            {
                temp.Previous = head;
            }
            Count++;
        }
        public bool Remove(T data)
        {
            LinkedListNode<T> previous=null;
            LinkedListNode<T> current = head;
            while (current !=null)
            {
                if (current.Value.Equals(data))
                {
                    if (previous != null)
                    {
                        previous.Next = current.Next;
                        if (current.Next == null)
                        {
                            tail = previous;
                        }
                        else
                        {
                            current.Next.Previous = previous;
                        }
                        Count--;
                    }
                    else
                    {
                        RemoveFirst();
                    }
                    return true;
                }
                previous = current;
                current = current.Next;
            }
            return false;
        }
        public void RemoveFirst()
        {
            if (Count != 0)
            {
                if (Count == 1)
                {
                    head = null;
                    tail = null;
                }
                else
                {
                    head = head.Next;
                    head.Previous = null;
                }
                Count--;
            }
        }
        public void RemoveLast()
        {
            if (Count!=0)
            {
                if (Count==1)
                {
                    head = null;
                    tail = null;
                }
                else
                {
                    tail.Previous.Next = null;
                    tail = tail.Previous;
                }
                Count--;
            }
        }
        public bool Contains(T data)
        {
            LinkedListNode<T> current = head;
            while (current !=null)
            {
                if (current.Value.Equals(data))
                {
                    return true;
                }
                current = current.Next;
            }
            return false;
        }
        public void Clear()
        {
            head = null;
            tail = null;
            Count = 0;
        }
        public IEnumerator<T> GetEnumerator()
        {
            LinkedListNode<T> current = head;
            while (current !=null)
            {
                yield return current.Value;
                current = current.Next;
            }
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IEnumerable<T>)this).GetEnumerator();
        }
    }
}
