using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyArrayList
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList<int> list1 = new ArrayList<int>();
            ArrayList<int> list2 = new ArrayList<int>(5);
            int[] arr = { 5, 6, 4, 7, 9, 41, 5, 2, 2 };
            ArrayList<int> list3 = new ArrayList<int>(arr);

            foreach (var item in list3)
            {
                Console.WriteLine(item);
            }   
        }
    }
}
