// branching - if, else if, else
public class Conditional
{
    public static void ConditionalMethod()
    {
        Console.WriteLine();
        Console.WriteLine("** File Conditional **");
        Console.WriteLine("Ternary Operator");
        int time1 = 20;
        string result = (time1 < 18) ? "Good day." : "Good evening.";
        Console.WriteLine(result);

        Console.WriteLine("If else if else");
        int time = 22;
        if (time < 10)
        {
            Console.WriteLine("Good morning.");
        }
        else if (time < 20)
        {
            Console.WriteLine("Good day.");
        }
        else
        {
            Console.WriteLine("Good evening.");
            Console.WriteLine("going to Focus go to statement!!!");
            goto focus;
        }
    focus:
        {
            Console.WriteLine("in focus..........");
            Console.WriteLine("out from focussss!!!???");
        }

        Console.WriteLine("switch statement with break;");
        int day = 4;
        switch (day)
        {
            case 1:
                Console.WriteLine("Monday");
                break;
            case 2:
                Console.WriteLine("Tuesday");
                break;
            case 3:
                Console.WriteLine("Wednesday");
                break;
            case 4:
                Console.WriteLine("Thursday");
                break;
            case 5:
                Console.WriteLine("Friday");
                break;
            case 6:
                Console.WriteLine("Saturday");
                break;
            case 7:
                Console.WriteLine("Sunday");
                break;
            //goto case 6;
            default:
                Console.WriteLine("Looking forward to the Weekend.");
                break;
        }
    }
}
