using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTree
{
    class Program
    {
        static void Main(string[] args)
        {
            BinaryTree<int> inctance = new BinaryTree<int>();
            inctance.Add(12);
            inctance.Add(5);
            inctance.Add(13);
            inctance.Add(6);
            inctance.Add(2);
            Console.WriteLine(inctance.Count);

            Console.WriteLine(inctance.Contains(6));
           
        }
    }
}
