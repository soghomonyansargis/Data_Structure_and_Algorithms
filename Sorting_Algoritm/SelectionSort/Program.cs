using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelectionSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 5, 3, 4, 2, 6, 8 };
            SelectSort(arr);
            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }
        }
        public static void Swap(int[] items,int left, int right)
        {
            if (items[left]!=items[right])
            {
                int temp = items[left];
                items[left] = items[right];
                items[right] = temp;
            }
        }
        public static void SelectSort(int []items)
        {
            int sortedRengAnd = 0;

            while (sortedRengAnd<items.Length)
            {
                int nextIndex = FindIndexOfSmallestOfIndex(items,sortedRengAnd);
                Swap(items, sortedRengAnd, nextIndex);
                sortedRengAnd++;
            }
        }
        public static int FindIndexOfSmallestOfIndex(int[] items, int sortedRengAnd)
        {
            int currentSmallest = items[sortedRengAnd];
            int currentSmallestIndex = sortedRengAnd;

            for (int i = sortedRengAnd +1; i < items.Length; i++)
            {
                if (currentSmallest.CompareTo(items[i])>0)
                {
                    currentSmallest = items[i];
                    currentSmallestIndex = i;
                }
            }
            return currentSmallestIndex;
        }
    }
}
