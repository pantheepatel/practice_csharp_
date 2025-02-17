// additional
// What is the Var data type? The keyword var is used to declare implicit type variables in C#, which means it tells the compiler to figure out the variable type at compilation time. A var variable must be initialized at the time of declaration. ​​var can contain any type of data.
// If you don't want other classes to inherit from a class, use the sealed keyword:



// questions
// what is the meaning of internal access modifier
// what is the significance of using private constructor
// why to make class private
// why can not make class private
// what is protected internal and private protected
// difference between encapsulation and abstraction
// what is the use of shorthand getter setter
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
            // method overloading occurs when there is same named method in same class with some difference
            // method overriding occurs when to extend class and override the method of parent class
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
            ClassAndObj obj5 = new ClassAndObj("Panthee", 22);

            // topic - Access Modifiers
            // public - accessible for all classes
            // private - only accessible within the same class
            // protected - accessible within the same class, or in a class that is inherited from that class.
            // internal - only accessible within its own assembly, but not from another assembly.
            // There's also two combinations: protected internal and private protected.


            // encapsulation; get set;
            // Person.name; // this is inaccessible due to its protection level
            // get and set this property using getter and setter
            Person person = new Person();
            // person.name is also not accessible
            person.Name = "panthee patel";
            Console.WriteLine($"name in person.name is: {person.Name}");
        }
    }
}