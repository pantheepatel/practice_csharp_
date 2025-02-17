namespace OOPs
{
    internal class ClassAndObj
    {
        public int myVar = 20;

        // when constructor is private, you can not make obj and can not inherit that class
        public ClassAndObj()
        {
            Console.WriteLine($"class and obj without params");
        }
        public ClassAndObj(string name)
        {
            Console.WriteLine($"class and obj with params {name}");
        }
        public ClassAndObj(string name, int myVar)
        {
            // this is referring to myVar of class you can change it with assigning param's myVar with this.myVar=myVar;
            Console.WriteLine($"class and obj with params and use of this {name},{myVar},{this.myVar}");
        }
        public int myAge()
        {
            return this.myVar;
        }
    }

    internal class ChildClassAndObj : ClassAndObj
    {
        public ChildClassAndObj()
        {
            Console.WriteLine("into the constructor of childClassAndObj");
        }
        public void ClassAndObj()
        {
            Console.WriteLine("child of class and obj");
        }
    }

    // below is the class to show the use of encapsulation, also how to get and set data for that
    class Person
    {
        private string name;
        public string Name
        {
            // 1st way
            //get { return name; }
            //set { name = value; }
            // 2nd way - shorthand (automatic properties)
            get; set;
        }
    }
}
