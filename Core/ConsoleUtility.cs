using System;
using System.Collections;
using System.Collections.Generic;

namespace Core
{
    public class ConsoleUtility
    {
        public static void WriteLine<T>(T array) where T : IEnumerable
        {
            foreach(var n in array)
            {
                Console.Write($"{n} ");
            }
            Console.WriteLine();
        }
    }
}
