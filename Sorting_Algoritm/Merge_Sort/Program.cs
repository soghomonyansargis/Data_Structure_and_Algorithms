using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Merge_Sort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 5, 3, 4, 2, 6, 8 };
            MergeSort(arr);
            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }
        }
        public static void MergeSort(int[]items)
        {
            if (items.Length<=1)
            {
                return ;
            }
            int leftSize = items.Length / 2;
            int rightSize = items.Length - leftSize;
            int[] left = new int[leftSize];
            int[] right = new int[rightSize];

            Array.Copy(items, 0, left, 0, leftSize);
            Array.Copy(items, leftSize, right, 0, rightSize);

            MergeSort(left);
            MergeSort(right);

            Merge(items, left, right);
        }
        public static void Merge(int[] items,int[] left,int[] right)
        {
            int leftIndex = 0;                   
            int rightIndex = 0;
            int targetIndex = 0;

            int remaining = left.Length + right.Length;

            while (remaining > 0)
            {
                if (leftIndex >= left.Length)
                {
                    items[targetIndex] = right[rightIndex++];
                }

                else if (rightIndex >= right.Length)
                {
                    items[targetIndex] = left[leftIndex++];
                }

                else if (left[leftIndex].CompareTo(right[rightIndex]) < 0)
                {
                    items[targetIndex] = left[leftIndex++];
                }

                else
                {
                    items[targetIndex] = right[rightIndex++];
                }

                targetIndex++;
                remaining--;
            }
        }

    }
}
