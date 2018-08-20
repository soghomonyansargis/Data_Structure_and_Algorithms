using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyHeap
{
    class Program
    {
        static void Main(string[] args)
        {
            MinHeap<int> minHeap = new MinHeap<int>();

            minHeap.Insert(5);
            minHeap.Insert(9);
            minHeap.Insert(3);
            minHeap.Insert(8);
           
            Console.WriteLine($"count = {minHeap.Count}, peek= { minHeap.Peek()}");
            foreach (var item in minHeap.Data)
            {
                Console.WriteLine(item);
            }
            int a= minHeap.ExtractMin();
            Console.WriteLine( $"min = {a}" );
        }
    }
}
