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

            // extension methods
            int num = 10;
            Console.WriteLine(num.IsEven());
            string text = "C# is an amazing language!";
            int count = text.WordCount(); // Calling the extension method like an instance method
            Console.WriteLine("Word Count: " + count);
        }
    }
}