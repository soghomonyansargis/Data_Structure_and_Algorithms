using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLinkedListOk
{
    class LinkedListNode<T>
    {
        public LinkedListNode( T value)
        {
            this.Value = value;
        }
        public T Value { get; internal set; }

        public LinkedListNode<T> Next { get; internal set; }
        public LinkedListNode<T> Previous { get; internal set; }
    }
}
