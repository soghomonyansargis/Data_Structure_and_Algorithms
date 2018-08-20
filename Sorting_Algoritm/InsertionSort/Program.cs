using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsertionSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 3, 4, 5, 6, 7, 2, 8 };
            InsertSort(arr);
            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }
        }
        static public int[] InsertSort(int [] item)
        {
            int sortedIndex = 1;
            while (sortedIndex < item.Length)
            {
                if (item[sortedIndex].CompareTo(item[sortedIndex - 1]) < 0)
                {
                    int InsertIndex = FindInsertIndex(item,item[sortedIndex]);
                    Insert(item,InsertIndex,sortedIndex);
                }
                sortedIndex++;
            }
            return item;
        }
        static public int FindInsertIndex(int[] items, int valuToInsert)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i].CompareTo(valuToInsert) >0)
                {
                    return i;
                }
            }
            throw new InvalidOperationException("index not found");
        }
        public static void Insert(int[] items, int insertIndexAt,int insertIndexFrom)
        {
            int temp = items[insertIndexAt];
            items[insertIndexAt] = items[insertIndexFrom];//swaping

            for (int i  = insertIndexFrom; i  > insertIndexAt; i --)//moveing right
            {
                items[i] = items[i - 1];
            }
            items[insertIndexAt + 1] = temp;
        }
    }
}
