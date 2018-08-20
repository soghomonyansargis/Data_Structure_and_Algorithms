using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyArrayList
{
    public class ArrayList<T>:IEnumerable<T>
    {
        T[] items;
        public ArrayList():this(0)
        {

        }
        public ArrayList(int size)
        {
            items = new T[size];
        }
        public ArrayList(ICollection<T> list)
        {
            int index = 0;
            items = new T[list.Count];
            foreach (var item in list)
            {
                items[index++] = item;
                Count++;
            }
        }
        public int Count
        {
            get;
            private set;
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < Count; i++)
            {
                yield return items[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
