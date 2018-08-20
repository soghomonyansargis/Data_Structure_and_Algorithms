using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedianOfMedians
{
    class Program
    {
        static void MinAndMax(int []A) 
        {
            int min = A[0];
            int max = A[0];
            StringBuilder builder = new StringBuilder($"{A[0]},");
           
            for (int i = 1; i < A.Length; i++)
            {
                if (min> A[i])
                {
                    min = A[i];
                }
                if (max<A[i])
                {
                    max = A[i];
                }
                builder.Append($"{A[i]},");
            }
            builder.Remove(builder.Length-1, 1);
            Console.WriteLine($"{builder} \n Min = {min}, Max = {max}");
        }
        static void Main(string[] args)
        { 
           int[] arr={ 5,3,6,4,0,2,9,1,8,2};
           MinAndMax(arr); 
        }
    }
}
