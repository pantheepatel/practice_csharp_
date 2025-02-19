using Humanizer;
//public class MyClass
//{
//    public static void Main()
//    {
//        Console.WriteLine("Hello World!");
//    }
//}
namespace csharpBasic
{
    internal class Program
    {
        private static void Main()
        {
            Console.WriteLine("Hello World! from csharpBasic".Pluralize());
            // normal TimeSpan
            Console.WriteLine(TimeSpan.FromMilliseconds(15000));
            //Humanizer is a library that helps you humanize values like time, numbers, and quantities.
            // Humanize is a method that converts a TimeSpan to a human-readable string.
            // we can find these packages in the NuGet package manager, for project into dependencies->Packages
            Console.WriteLine(TimeSpan.FromMilliseconds(1508270).Humanize(3));
            // .WriteLine() is a method that writes a string followed by a line terminator to the console window.
            // .Write() is a method that writes a string to the console window.
            csharpBasic.Hello.SayHello();
            csharpBasic.VariablesDatatypePractice.variablesMethod();
            // int a = null; // by default it can't accept null values so use ?
            int? a = null;

            // topic: userInput 
            // when you are dealing with userinput you should use type conversion methods, so it will give only exception.
            // to access the methods of class
            string fname = UserInput.UserInputMethodFname(); // if method is static, can directly access it.
            UserInput obj1 = new UserInput(); // to use non-static method have to make obj of that class
            string lname = obj1.UserInputLname();
            Console.WriteLine("your fullname is: " + fname + " " + lname);

            // topic: operators - arithmetic, assignment, comparison, logical
            OperatorAndMath.Operators();

            // topic: strings - methods, properties
            Strings.stringsMethod();

            // topic: conditional - if, else if, if, ? :
            Conditional.ConditionalMethod();

            // topic: loops - while, do while, for, foreach
            Loops.MyLoops();

            // topic: Arrays - 
            Arrays_.MyArrMethod();
        }
    }
}