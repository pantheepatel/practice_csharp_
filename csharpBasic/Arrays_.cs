
using System;

public class Arrays_
{
    public static void MyArrMethod()
    {
        Console.WriteLine();
        Console.WriteLine("** File Arrays_ **");

        // 1st method
        //string[] cars;
        //cars = new string[] { "Volvo", "BMW", "Ford" };

        // 2nd method
        // Create an array of four elements, and add values later
        //string[] cars = new string[4];

        // 3rd method
        // Create an array of four elements and add values right away 
        //string[] cars = new string[4] { "Volvo", "BMW", "Ford", "Mazda" };

        // 4th method
        // Create an array of four elements without specifying the size 
        //string[] cars = new string[] { "Volvo", "BMW", "Ford", "Mazda" };

        // 5th method
        // Create an array of four elements, omitting the new keyword, and without specifying the size
        string[] cars = { "Volvo", "BMW", "Ford", "Mazda" };
        Console.WriteLine(cars); // will not print array.
        Console.WriteLine("Befor Array.Sort method");
        Loops.forEachMethod(cars);
        Array.Sort(cars);
        Console.WriteLine("After Array.Sort method");
        Loops.forEachMethod(cars);
        //Console.WriteLine($"After Array.Sort method : {0}" , Loops.forEachMethod(cars));

        int[] myNumbers = { 5, 1, 8, 9 };
        Console.WriteLine(myNumbers.Max());
        Console.WriteLine(myNumbers.Min());
        Console.WriteLine(myNumbers.Sum());

        int[,] numbers = { { 1, 4, 2 }, { 3, 6, 8 } };
        Console.WriteLine(numbers[0, 2]);
        //Console.WriteLine(numbers[1]); //will give error
    }
}
