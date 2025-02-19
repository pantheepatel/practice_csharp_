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

        virtual public void voice()
        {
            Console.WriteLine("voice from parent");
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
        override public void voice()
        {
            Console.WriteLine("voice from child");
        }
        public void voice2() {
            Console.WriteLine("this is voice 2");
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

    abstract class Animal
    {
        // Abstract method (does not have a body)
        public abstract void animalSound();
        // Regular method
        public void sleep()
        {
            Console.WriteLine("Zzz");
        }
    }

    // Derived class (inherit from Animal)
    class Pig : Animal
    {
        public override void animalSound()
        {
            // The body of animalSound() is provided here
            Console.WriteLine("The pig says: wee wee");
        }
    }

    //class deriveFromUserInput: UserInput { }
    // checking for access modifiers

    class modifiersCSharp
    {
        public void testAccess()
        {
            // Member value is Accessible
            checkClasses obj1 = new checkClasses();
            //obj1.value5 = 12; //change variable from value1 to value5
        }
    }
}
