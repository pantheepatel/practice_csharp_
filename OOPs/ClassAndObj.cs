namespace OOPs
{
    public class ClassAndObj
    {
        public int myVar = 20;
        ~ClassAndObj()
        {
            Console.WriteLine("destructor is called and freeing up memory,...");
        }
        // when constructor is private, you can not make obj and can not inherit that class
        internal ClassAndObj()
        {
            Console.WriteLine($"class and obj without params");
        }
        static ClassAndObj()
        {
            Console.WriteLine("static con");
        }
        public ClassAndObj(int var1)
        {
            this.myVar = var1;
        }
        public ClassAndObj(ClassAndObj copyConObj)
        {
            myVar = copyConObj.myVar;
            Console.WriteLine("my var in copy con is: " + myVar);
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
        public void voice2()
        {
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

    abstract class abClass
    {
        int x = 0;
        //abstract pVar;
        public abstract void abMethod();
    }

    class abClassImplement : abClass
    {
        override public void abMethod()
        {
            Console.WriteLine("into implementation of abclass abstract method");
        }
        public void otherMethod()
        {
            Console.WriteLine("other method of abClassImplement");
        }
    }
}
