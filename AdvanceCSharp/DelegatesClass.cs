using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvanceCSharp
{
    class DelegatesClass
    {
        public delegate void WorkHandler(int hours);
        WorkHandler del1 = new WorkHandler(WorkMethod);
        //del1(10); //error as it is directly under class ot any method.

        // Constructor
        public DelegatesClass()
        {
            // Assign the delegate to the static method
            del1 = new WorkHandler(WorkMethod);

            // Invoke the delegate
            del1(10);
        }
        public static void WorkMethod(int wHours)
        {
            Console.WriteLine(wHours);
        }
    }
}
