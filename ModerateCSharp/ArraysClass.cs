using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModerateCSharp
{
    class ArraysClass
    {
        public static void ArraysClassMethod()
        {
            int[] arr1 = new int[5];
            int[] arr2 = { 1, 2, 3, 4, 5 };  // Inline initialization
            int[] arr3 = new int[] { 10, 20, 30 };  // With 'new' keyword
            int[] numbers = { 10, 20, 30 };
            Console.WriteLine("Member of array: " + numbers[1]);
            numbers[2] = 50;  // Modify value
            Console.WriteLine("After modification: " + numbers[2]);

            // looping
            foreach (int num in numbers)
            {
                Console.WriteLine(num);
            }
        }

        public static void MultiArrayClassMethod()
        {
            int[,] matrix = new int[2, 2] { { 1, 2 }, { 3, 4 } };
            Console.WriteLine(matrix[1, 0]);
            //int[][] jagged = new int[2][];
            //jagged[0] = new int[] { 1, 2 };
            //jagged[1] = new int[] { 3, 4, 5 };
            int[][] jagged= [new int[] { 1, 2 }, new int[] { 3, 4, 5 }];
            Console.WriteLine(jagged[1][2]);
        }
    }
}
