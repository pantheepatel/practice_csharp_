using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvanceCSharp
{
    class ArrayListClass
    {
        public void ArrayListClassMethod()
        {
            Console.WriteLine("* into arraylist method *");
            ArrayList myList = new ArrayList();

            // Adding elements in the ArrayList
            myList.Add(12.56);
            myList.Add("Panthee Patel");
            myList.Add(null);
            myList.Add('P');
            myList.Add(1234);

            // Accessing the elements 
            foreach (var elements in myList)
            {
                Console.Write(elements + ",");
            }

            // Displaying count of elements of ArrayList 
            Console.WriteLine("Number of elements: " + myList.Count);

            // Displaying Current capacity of ArrayList 
            Console.WriteLine("Current capacity: " + myList.Capacity);

            //myList.Remove('h'); // myList isn't containing this char, won't throw exception
            myList.Remove('P'); // will remove it
            //myList.RemoveAt(8); // throw exception
            //myList.RemoveRange(1, 7); // throw exception
            myList.Clear(); //clear whole list
            Console.WriteLine("After applying different methods the number of elements: " + myList.Count);

        }
        public void ArrayListDefaultMethod()
        {

            Console.WriteLine("\n* into ArrayListDefaultMethod method *");
            //ArrayList myList = new ArrayList() { "panthee", 1, 'p', null, 12.4 }; //cannot apply default method cause of diff types
            ArrayList myList = new(5) { 1, 34, 56, 13, 6 };

            // sorting
            myList.Sort();
            foreach (var item in myList)
            {
                Console.Write(item + ",");
            }
            //Console.WriteLine(myList.Sort());
        }
    }
}
