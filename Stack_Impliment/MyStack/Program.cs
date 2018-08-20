using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyStack
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> stack = new Stack<int>();
            stack.Push(10);
            stack.Push(5);
            stack.Push(8);         
            Console.WriteLine("Peek " + stack.Peek());
            Console.WriteLine("Count " + stack.Count);
        }
    }
}
