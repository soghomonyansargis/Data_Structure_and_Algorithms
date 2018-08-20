using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLinkedListOk
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList<int> list = new LinkedList<int>();
            list.AddFirst(12);
            list.AddFirst(1);
            list.AddLast(9);

            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
           
        }
    }
}
