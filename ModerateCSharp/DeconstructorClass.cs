using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModerateCSharp
{
    class DeconstructorClass
    {
    }

    class Person
    {
        public string Name { get; }
        public int Age { get; }

        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }

        // Deconstructor Method
        public void Deconstruct(out string name, out int age)
        {
            name = Name;
            age = Age;
        }
    }


}
