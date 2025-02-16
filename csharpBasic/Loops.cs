public class Loops
{
    public static void MyLoops()
    {
        Console.WriteLine();
        Console.WriteLine("** File Loops **");
        Console.WriteLine("while loop");
        int i = 0;
        while (i < 5)
        {
            if (i == 4)
            {
                i++;
                continue;
            }
            Console.Write(i);
            i++;
        }
        Console.WriteLine();
        Console.WriteLine("do while loop");
        int j = 0;
        do
        {
            if (j == 4)
            {
                j++;
                break;
            }
            Console.Write(j);
            j++;
        }
        while (i < 5);
        Console.WriteLine();
        Console.WriteLine("for loop");
        for (int k = 0; k < 5; k++)
        {
            Console.Write(k);
        }

        Console.WriteLine();
        Console.WriteLine("foreach, refer array");
    }

    public static void forEachMethod(string[] cars)
    {
        foreach (string ele in cars)
        {
            Console.WriteLine(ele);
        }
    }
}
