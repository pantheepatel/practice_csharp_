namespace AdvanceCSharp
{
    class AdvanceCSharp
    {
        static void Main(string[] args)
        {
            //// ArrayList
            //ArrayListClass alcVar = new();
            //alcVar.ArrayListClassMethod();
            //alcVar.ArrayListDefaultMethod();

            //// List
            //ListClass alVar = new();
            //alVar.ArrayListMethod();

            //// Hashtable
            //HashtableClass hashVar = new();
            //hashVar.HashtableClassMethod();

            //// dictionary 
            //DictionaryClass dictVar = new();
            //dictVar.DictionaryClassMethod();

            //// extension methods
            //int num = 10;
            //Console.WriteLine(num.IsEven());
            //string text = "C# is an amazing language!";
            //int count = text.WordCount(); // Calling the extension method like an instance method
            //Console.WriteLine("Word Count: " + count);

            //// generics
            //// generic class
            //Generics_<int> num1 = new();
            //num1.value = 23;
            //Console.WriteLine("value of num1: " + num1.value);
            //// generic method
            //GenericMethodClass var1 = new();
            //var1.Display("str1", 23);
            //var1.Display<string>("str2", "str msg");

            // events and delegates
            // Creating an object of the class will trigger the constructor
            DelegatesClass obj = new DelegatesClass();
        }
    }
}