using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core
{
    public class ArrayUtility
    {
        private readonly static Random rd = new Random();

        public static int[] CreateRandomIntArray(int length)
        {
            return Enumerable.Range(0, length).Select(_ => rd.Next(0, length)).ToArray();
        }

        public static int[] CreateSortedIntArray(int length)
        {
            var array = CreateRandomIntArray(length);
            return array.OrderBy(x => x).ToArray();
        }

        public static int[] CraeteReverseSortedIntArray(int length)
        {
            var array = CreateRandomIntArray(length);
            return array.OrderByDescending(x => x).ToArray();
        }
    }
}
