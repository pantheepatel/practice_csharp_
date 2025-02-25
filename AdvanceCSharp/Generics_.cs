using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvanceCSharp
{
    public class Generics_<T>
    {

        // private data members
        private T data;

        // using properties
        public T value
        {

            // using accessors
            get
            {
                return this.data;
            }
            set
            {
                this.data = value;
            }
        }
    }
    class GenericMethodClass
    {
        public void GenericMethod<GenParam1>(GenParam1 str)
        {
            GenericMethodClass name = new GenericMethodClass();
            string name2 = (typeof(GenParam1) == typeof(string)) ? "Panthee" : null;
        }
        // Generics method
        public void Display<TypeOfValue>(string msg, TypeOfValue value)
        {
            Console.WriteLine("{0}:{1}", msg, value);
        }
    }
}
