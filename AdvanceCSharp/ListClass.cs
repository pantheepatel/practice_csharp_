using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace AdvanceCSharp
{
    class ListClass
    {
        public void ArrayListMethod()
        {
            // default constructor creates an empty list
            List<int> list = new List<int>();
            list.Add(10);
            list.Add(20);
            Console.Write("Default Constructor: ");
            foreach (var item in list)
            {
                Console.Write(item+" ");
            }
            Console.WriteLine();
            
            // Construnctors from IEnumerable
            int[] num = { 10, 20 };
            List<int> enumerableList = new List<int>(num);
            Console.Write("Constructor with IEnumerable: ");
            foreach (var item in enumerableList)
            {
                Console.Write(item+" ");
            }
            Console.WriteLine();
            
            // Constructor with Initial Capacity 
            List<int> Clist = new List<int>(2);
            Clist.Add(10);
            Clist.Add(20);
            Console.Write("Constructor with Initial Capacity: ");
            foreach (var item in Clist)
            {
                Console.Write(item+" ");
            }
            Console.WriteLine();
        }
    }
}
