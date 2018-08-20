using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BubbleSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int []arr = { 15, 26, 3, 14, 2, 5, 9, 87, 6, 45, 3 ,0};

            arr = Bubble(arr);
            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }
        }
        public static int[] Bubble(int [] arr)
        {
            for (int i = 0; i < arr.Length-1; i++)
            {
                for (int j =0; j < arr.Length-i-1;j++ )
                {
                    if (arr[j] > arr[j+1])
                    {
                        int temp = arr[j];
                        arr[j] = arr[j+1];
                        arr[j+1] = temp;
                    }
                }
            }
            return arr;
        }
    }
}
