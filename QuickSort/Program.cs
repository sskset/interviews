using System;
using System.Linq;

namespace QuickSort
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int count = 11;

            var rd = new Random();
            int[] rawArray = Enumerable.Range(0, count).Select(_ => rd.Next(0, count)).ToArray();

            foreach (int n in rawArray)
            {
                Console.Write($"{n} ");
            }

            Console.WriteLine();

            QuickSort(rawArray, 0, rawArray.Length - 1);

            foreach (int n in rawArray)
            {
                Console.Write($"{n} ");
            }
            Console.WriteLine();

            Console.ReadKey();
        }

        private static void QuickSort(int[] array, int left, int right)
        {
            if (left < right)
            {
                int middle = Partition(array, left, right);

                QuickSort(array, left, middle - 1);
                QuickSort(array, middle + 1, right);
            }
        }

        private static int Partition(int[] array, int left, int right)
        {
            int pivot = array[left];

            while (left < right)
            {
                while (left < right && array[right] >= pivot)
                {
                    right--;
                }

                array[left] = array[right];

                while (left < right && array[left] < pivot)
                {
                    left++;
                }

                array[right] = array[left];
            }

            array[left] = pivot;

            return right;
        }
    }
}
