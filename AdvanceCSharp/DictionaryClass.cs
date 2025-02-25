using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvanceCSharp
{
    class DictionaryClass
    {
        public void DictionaryClassMethod()
        {
            // Creating a dictionary
            Dictionary<int, string> dict = new Dictionary<int, string>();

            // Adding elements
            dict.Add(1, "C#");
            dict.Add(2, "Javascript");
            dict.Add(3, "Dart");
            dict[4] = "four";

            // Displaying dictionary
            foreach (var ele in dict)
            {
                Console.WriteLine($"Key: {ele.Key}, Value: {ele.Value}");
            }

            // Remove a key-value pair
            dict.Remove(3);


            Console.WriteLine(dict.ContainsValue("One"));
            //Console.WriteLine(dict.ContainsKey("One")); // error
        }
    }
}
