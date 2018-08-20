using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTree
{
    class BinaryTreeNode<T>:IComparable<T> where T: IComparable<T>
    {
        public BinaryTreeNode(T value)
        {
            this.Value = value;
        }

        public BinaryTreeNode<T> Left { get; set; }
        public BinaryTreeNode<T> Right { get; set; }

        public T Value { get; private set; }

        public int CompareTo(T other)
        {
            return Value.CompareTo(other);
        }
    }
}
