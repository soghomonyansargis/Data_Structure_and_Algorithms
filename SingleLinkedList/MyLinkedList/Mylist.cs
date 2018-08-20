using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLinkedList
{
    public class Mylist<T>:IEnumerable
    {
        public MyLinkedlistNode<T> _head;
        public MyLinkedlistNode<T> _last;
        public int Count { get; private set; }

        public void Add( T value)
        {
            MyLinkedlistNode<T> node = new MyLinkedlistNode<T>(value);
            if (_head == null)
            {
                _head = node;
                _last = node;
            }
            else
            {
                _last.Next = node;
                _last = node;
            }
            Count++;
           // Console.WriteLine(value + " is added");
        }
       

        public bool Remove(T item)
        {
            MyLinkedlistNode<T> previous = null;
            MyLinkedlistNode<T> current = _head;
            while (current != null)
            {
                if (current.Data.Equals(item))
                {
                    if (previous !=null)
                    {
                        previous.Next = current.Next;

                        if (current.Next == null)
                        {
                            _last = previous;
                        }
                    }

                    else
                    {
                        _head = _head.Next;

                        if (_head == null)
                        {
                            _last = null;
                        }
                    }
                    Count--;
                  //  Console.WriteLine(item + " is Removed");
                    return true;
                }
                previous = current;
                current = current.Next;
            }
            return false;
        }

      

        public IEnumerator GetEnumerator()
        {
            MyLinkedlistNode<T> current = _head;
            while(current != null)
            {
                yield return current.Data;
                current = current.Next;
            }
        }

        public void CopyTo(T[] arr,int index)
        {
            MyLinkedlistNode<T> current = _head;
            while (current != null)
            {
                arr[index++] = current.Data;
                current = current.Next;
            }
        }

        public void Display(Mylist<T> words)
        {
            foreach (T word in words)
            {
                Console.Write(word + ", ");
            }
            Console.WriteLine();

        }
    }
}
