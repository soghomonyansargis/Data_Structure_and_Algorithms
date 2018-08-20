using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heap_Sort
{
    class HeapSort
    {
        public int[] Sort(int[] a)
        {
            // Turn the array into a max heap  
            for (int i = (a.Length / 2) - 1; i >= 0; i--)
            {
                MaxHeapify(a, i, a.Length);
            }

            // Remove the largest element from the max heap and put it on the end,  
            // and then max heapify the heap which is now 1 smaller  
            for (int i = a.Length - 1; i >= 1; i--)
            {
                Swap(a, 0, i);
                MaxHeapify(a, 0, i);
            }
            return a;
        }

        private void MaxHeapify(int[] a, int i, int n)
        {
            int idxLeft = (i + 1) * 2 - 1;
            int idxRight = (i + 1) * 2 - 1 + 1;

            int largest = i;

            if (idxLeft < n && a[idxLeft] > a[largest])
            {
                largest = idxLeft;
            }

            if (idxRight < n && a[idxRight] > a[largest])
            {
                largest = idxRight;
            }

            if (largest != i)
            {
                Swap(a, i, largest);
                MaxHeapify(a, largest, n);
            }

        }
        private void Swap(int[] a, int i, int j)
        {
            int tmp = a[i];
            a[i] = a[j];
            a[j] = tmp;
        }
    }
}
