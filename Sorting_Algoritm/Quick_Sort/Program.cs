using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quick_Sort
{
    class Program
    {
        static public void QuickSortArr(int[] arr)
        {
            quickSort(arr, 0, arr.Length - 1);
        }
        public static void Swap(int[] arr, int left, int right)
        {
            if (left != right)
            {
                int temp = arr[left];
                arr[left] = arr[right];
                arr[right] = temp;
            }
        }

        static private void quickSort(int[] arr, int left, int right)
        {
            Random pivotNum = new Random();
            if (left < right)
            {
                int pivotIndex = pivotNum.Next(left, right);
                int newPivot = Partition(arr, left, right, pivotIndex);
                quickSort(arr, left, newPivot - 1);
                quickSort(arr, newPivot + 1, right);
            }
        }
        static private int Partition(int[] arr, int left, int right, int pivotIndex)
        {
            int pivotValue = arr[pivotIndex];
            Swap(arr, pivotIndex, right);
            int sortIndex = left;

            for (int i = left; i < right; i++)
            {
                if (arr[i].CompareTo(pivotValue) < 0)
                {
                    Swap(arr, i, sortIndex);
                    sortIndex++;
                }
            }
            Swap(arr, sortIndex, right);
            return sortIndex;
        }
        static void Main(string[] args)
        {
            int[] arr = { 5, 23, 8, 9, 7, 6 };
            QuickSortArr(arr);

            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }
        }
    }
}
