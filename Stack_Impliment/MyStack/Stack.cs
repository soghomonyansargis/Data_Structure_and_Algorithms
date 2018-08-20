using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyStack
{
    public class Stack<T>
    {
        LinkedList<T> list = new LinkedList<T>(); 
        public void Push(T value)
        {
            list.AddLast(value);
        }
        public void Pop()
        {
            if (list.Count==0)
            {
                throw new InvalidOperationException("Stack is empaty");
            }
            list.RemoveLast();
        }
        public T Peek()
        {
            if (list.Count == 0)
            {
                throw new InvalidOperationException("Stack is empaty");
            }
           return list.Last.Value;
        }
        public bool Empaty()
        {
            if (list.Count == 0)
            {
                return true;
            }
            return false;
        }
        public int Count
        {
            get { return list.Count; }
        }
    }
}
