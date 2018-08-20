using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heap_Sort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 6, 9, 4, 7, 3, 9, 6, 7, 2, 5, 4, 6, 4, 8, 5, 0 };

            HeapSort sort = new HeapSort();
            sort.Sort(arr);
            Console.WriteLine("sorted");
            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }
        }
    }
}
