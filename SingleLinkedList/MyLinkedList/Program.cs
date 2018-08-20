using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            Mylist<int> my = new Mylist<int> ();
            Mylist<string> str = new Mylist<string>();
            my.Add(5);
            my.Add(6);
            my.Add(7);
            my.Add(7);
            my.Add(15);
            Console.WriteLine("Count of elements = "+my.Count);
            my.Display(my);

            int[] arr = new int[my.Count];

            my.CopyTo(arr, 0);

            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
        }
    }
}
