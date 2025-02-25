using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvanceCSharp
{
    static class ExtensionMethodClass
        // naming for these class should be like IntExtensions, StringExtensions
    {
        public static bool IsEven(this int number)
        {
            return number % 2 == 0;
        }
        public static int WordCount(this string str)
        {
            if (string.IsNullOrWhiteSpace(str))
                return 0;
            return str.Split(' ', StringSplitOptions.RemoveEmptyEntries).Length;
        }
    }
}
