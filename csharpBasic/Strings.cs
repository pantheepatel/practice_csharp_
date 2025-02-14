public class Strings
{
    public static void stringsMethod()
    {
        Console.WriteLine();
        Console.WriteLine("** File String **");
        string text1 = "Panthee patel";
        string text2 = "from Simform";
        string text3 = ", studied from LJ";
        // length is property not method
        Console.WriteLine("len of str is : " + text1.Length);
        Console.WriteLine("uppercase of str is : " + text1.ToUpper());
        Console.WriteLine(string.Concat(text1, text2, text3));
        // String Interpolation
        Console.WriteLine("String Interpolation: ");
        int age = 20;
        Console.WriteLine($"my age is: {age}");
        // access strings
        Console.WriteLine(string.Format("my age is: {0}", "my age is: {1}", age, text1));
        Console.WriteLine(string.Format("my age is: {0}", age));

        Console.WriteLine("my name's 1st letter is : " + text1[0]);
        Console.WriteLine("index of p is : " + text1.IndexOf('p'));

        string text4 = text1.Substring(6);
        Console.WriteLine("substring of text1, form index 6: " + text4);

        Console.WriteLine("to write \" add \\ same for \' ");
    }
}
