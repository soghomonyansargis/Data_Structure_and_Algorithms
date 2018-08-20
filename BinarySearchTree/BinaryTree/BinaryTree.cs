using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTree
{
    class BinaryTree<T> : IEnumerable<T> where T : IComparable<T>
    {
        public BinaryTreeNode<T> head;
        private int count;

        public int Count{ get { return count; } }
        public void Add(T value)
        {
            if (head == null)
            {
                head = new BinaryTreeNode<T>(value);
            }
            else
            {
                AddTo(head, value);
            }
            count++;
        }
        private void AddTo(BinaryTreeNode<T> node , T value)
        {
            if (value.CompareTo(node.Value)<0)
            {
                if (node.Left==null)
                {
                    node.Left = new BinaryTreeNode<T>(value);
                }
                else
                {
                    AddTo(node.Left, value);
                }
            }
            else
            {
                if (node.Right==null)
                {
                    node.Right = new BinaryTreeNode<T>(value);
                }
                else
                {
                    AddTo(node.Right, value);
                }
            }
        }

        public bool Contains(T value)
        {
            BinaryTreeNode<T> parent;
            return FindWithParent(value, out parent) != null;
            
        }
        private BinaryTreeNode<T> FindWithParent(T value, out BinaryTreeNode<T> parent)
        {
            BinaryTreeNode<T> current = head;
            parent = null;

            while (current !=null)
            {
                int result = current.CompareTo(value);
                if (result>0)
                {
                    parent = current;
                    current = current.Left;
                }
                else if (result < 0)
                {
                    parent = current;
                    current = current.Right;
                }
                else
                {
                    break;
                }
            }
            return current;
        }


        public bool Remove(T value)
        {
            BinaryTreeNode<T> current;
            BinaryTreeNode<T> parent;

            current = FindWithParent(value, out parent);
            if (current == null)
            {
                return false;
            }
            count--;
            //1 depq chka aj jarang

            if (current.Right==null)
            {
                if (parent == null)
                {
                    head = current.Left;
                }
                else
                {
                    int result = parent.CompareTo(current.Value);

                    if (result>0)
                    {
                        parent.Left = current.Left;
                    }
                    else if (result < 0)
                    {
                        parent.Right = current.Left;
                    }
                }
            }
            //2  depq uni aj jarang vor@  chuni dzax jarang
            else if (current.Right.Left==null)
            {
                current.Right.Left = current.Left;

                if (parent==null)
                {
                    head = current.Right;
                }
                else
                {
                    int result = parent.CompareTo(current.Value);
                    if (result>0)
                    {
                        parent.Left = current.Right;
                    }
                    else if (result<0)
                    {
                        parent.Right = current.Right;
                    }
                }
            }
            //3 depq erb aj jarang vor@ uni dzax jarang
            else
            {
                BinaryTreeNode<T> leftmost = current.Right.Left;
                BinaryTreeNode<T> leftmostParent = current.Right;
                while (leftmost.Left != null)
                {
                    leftmostParent = leftmost;
                    leftmost = leftmost.Left;
                }
                leftmostParent.Left = leftmost.Right;

                leftmost.Left = current.Left;
                leftmost.Right = current.Right;

                if (parent == null)
                {
                    head = leftmost;
                }
                else
                {
                    int result = parent.CompareTo(current.Value);

                    if (result>0)
                    {
                        parent.Left = leftmost;
                    }
                    else if (result<0)
                    {
                        parent.Right = leftmost;
                    }
                }

            }
            return true;
        }

        public IEnumerator<T> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
