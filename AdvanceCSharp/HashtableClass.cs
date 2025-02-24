using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvanceCSharp
{
    class HashtableClass
    {
        public void HashtableClassMethod()
        {
            Hashtable ht = new();

            // Add key-value pairs to the Hashtable
            ht.Add("One", 1);
            ht.Add("Two", 2);
            ht.Add("Three", 3);

            Console.WriteLine("Hashtable elements:");
            foreach (DictionaryEntry e in ht)
            {
                Console.WriteLine($"{e.Key}: {e.Value}");
            }
            // updation
            string s = "key1";
            if (ht.ContainsKey(s))
            {
                ht[s] = "s1";
            }
            Console.WriteLine(ht.ContainsValue("One"));
            Console.WriteLine(ht.ContainsKey("One"));
            Console.WriteLine(ht.Contains("One"));

            Hashtable h2 = new Hashtable() {{ 1, "hello" }, { 2, 234 }, { 3, 230.45 },{4, null}};
            foreach (var ele2 in h2.Keys)
            {
                Console.WriteLine("{0} and {1}", ele2,
                                  h2[ele2]);
            }
            h2.Remove(1);
            //h2.Remove("2");
            //h2.Remove(32);
            //h2.Clear();
        }
    }
}
