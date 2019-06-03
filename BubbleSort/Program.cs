using Core;
using System;

namespace BubbleSort
{
    class Program
    {
        static void Main(string[] args)
        {

            var rawInput = ArrayUtility.CreateRandomIntArray(10);
            ConsoleUtility.WriteLine(rawInput);

            BubbleSort(rawInput);

            ConsoleUtility.WriteLine(rawInput);

            Console.ReadKey();
        }

        static void BubbleSort(int[] array)
        {
            for(int i = 0; i < array.Length; i++)
            {
                for(int j = i + 1; j < array.Length; j++)
                {
                    if (array[j] < array[i])
                    {
                        int temp = array[j];
                        array[j] = array[i];
                        array[i] = temp;
                    }
                }
            }
        }
    }
}
