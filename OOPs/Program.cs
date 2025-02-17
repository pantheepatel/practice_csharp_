using System.Security.AccessControl;

namespace OOPs
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Into new Project: OOPs");

            // topic - methods
            //public static void Main()
            //static means that the method belongs to the Program class and not an object of the Program class.
            MethodsFile.MyMethod("Panthee", 20); // this passed value is called argument
            MethodsFile.MyMethod(); // use of default parameters
            MethodsFile.MyMethod(age: 16, name: "Nehee Patel");
            MethodsFile.methodOverloading();

            // topic - class and objects
            ClassAndObj obj1 = new ClassAndObj();
            obj1.myVar = 21; // changing the variable for specific obj
            Console.WriteLine("Age is for obj1 : " + obj1.myAge());
            ClassAndObj obj2 = new ClassAndObj();
            Console.WriteLine("Age is for obj2 : " + obj2.myAge());

            // topic - constructor
            // invokation of blank constructor
            ClassAndObj obj3 = new ClassAndObj();
            // invokation of parameterised constructor
            ClassAndObj obj4 = new ClassAndObj("Panthee");
            // invokation of parameterised constructor
            ClassAndObj obj5 = new ClassAndObj("Panthee",22);

            // topic - Access Modifiers
            // public - accessible for all classes
            // private - only accessible within the same class
            // protected - accessible within the same class, or in a class that is inherited from that class.
            // internal - only accessible within its own assembly, but not from another assembly.
            // There's also two combinations: protected internal and private protected.
        }
    }
}