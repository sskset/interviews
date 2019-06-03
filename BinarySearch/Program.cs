using Core;
using System;

namespace BinarySearch
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int[] array = ArrayUtility.CreateSortedIntArray(10);
            ConsoleUtility.WriteLine(array);

            int target = 5;

            Console.WriteLine($"Looking for {target}");

            int index = BinarySearch(array, target);

            Console.WriteLine($"Index={index}");
            Console.ReadKey();
        }

        private static int BinarySearch(int[] array, int target)
        {
            int left = 0;
            int right = array.Length - 1;

            while (left < right)
            {
                int middle = (left + right) / 2;

                if (array[middle] < target)
                {
                    left = ++middle;
                }
                else if (array[middle] > target)
                {
                    right = --middle;
                }
                else
                {

                    return middle;
                }
            }

            return -1;
        }

        private static int BinarySearchLowestBound(int[] array, int target)
        {
            int left = 0;
            int right = array.Length - 1;

            while(left < right)
            {
                int middle = (left + right) / 2;

                if (array[middle] <= target)
                {
                    left = middle + 1;
                }
                else
                {
                    right = middle - 1;
                }
            }
        }
    }
}
