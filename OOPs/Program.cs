﻿// additional
// What is the Var data type? The keyword var is used to declare implicit type variables in C#, which means it tells the compiler to figure out the variable type at compilation time. A var variable must be initialized at the time of declaration. ​​var can contain any type of data.
// If you don't want other classes to inherit from a class, use the sealed keyword:
// Why And When To Use "Inheritance" and "Polymorphism"?
// It is useful for code reusability: reuse fields and methods of an existing class when you create a new class.


// questions
// Interfaces
// Structs and Enums
// Immutability
// Arrays, string
// what is the significance of using private constructor
// default, Parameterized, copy, static, private, public, protected, internal constructors. Chained Constructor (Constructor Overloading)
// extern and partial
// scenario based questions

namespace OOPs
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            //Console.BackgroundColor = ConsoleColor.Cyan;
            Console.Title = "hello";
            Console.ForegroundColor = ConsoleColor.Green;

            long longVar = 1223457444533;


            Console.WriteLine("Into new Project: OOPs");

            ClassAndObj copy1ForGC = new ClassAndObj();
            copy1ForGC = null; // eligible for GC
            System.GC.Collect(); // forcefully making call to garbage collector bcz sometime destructor might not run


            ClassAndObj copyConObj1 = new ClassAndObj(10);
            ClassAndObj copyConObj2 = new ClassAndObj(20);
            ClassAndObj copyConObj3 = new ClassAndObj(copyConObj2);

            // topic - methods
            //public static void Main()
            //static means that the method belongs to the Program class and not an object of the Program class.
            MethodsFile.MyMethod("Panthee", 20); // this passed value is called argument
            MethodsFile.MyMethod(); // use of default parameters
            MethodsFile.MyMethod(age: 16, name: "Nehee Patel");

            // polymorphism
            // method overloading occurs when there is same named method in same class with some difference
            // method overload means compile time Polymorphism
            // method overriding occurs when to extend class and override the method of parent class
            // method overriding means run time Polymorphism
            // when method overriding occurs, you should use virtual keyword in parent class and override keyword in child class to achieve overriding by child
            MethodsFile.methodOverloading();
            Console.WriteLine("checking..... method overriding and virtual override keywords");
            ClassAndObj objParent = new ClassAndObj();
            objParent.voice();
            // this will give perfect output as its class is childclassobj but when you make var type of parentclass then problem will occur if you haven't used keywords
            ChildClassAndObj objChild = new ChildClassAndObj();
            objChild.voice();
            // dynamic binding
            ClassAndObj objChildParent = new ChildClassAndObj();
            objChildParent.voice();
            //objChildParent.voice2(); // can't use voice2() bcz there is no declaration of method in ClassAndObj(parent) reference type

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
            // sealed - don't want other classes to inherit from this class
            // abstract - for method and class only
            // virtual 
            // override
            // There's also two combinations: protected internal and private protected.
            // if you want to make your class private(i.e. does not allow obj making, does not allow for inheritance) then make constructor private
            // if you want class should not be inherited but can make objects then use sealed keyword

            // encapsulation; get set;
            // Abstraction is a process of hiding the implementation details of a system from the user, and only the functional details will be available to the user end.
            // On the other hand, Encapsulation is a method of wrapping up the data and code acting on the data into a single unit.
            // Person.name; // this is inaccessible due to its protection level
            // get and set this property using getter and setter
            Person person = new Person();
            // person.name is also not accessible
            person.Name = "panthee patel";
            Console.WriteLine($"name in person.name is: {person.Name}");

            // abstraction
            Pig myPig = new Pig(); // Create a Pig object
            myPig.animalSound();  // Call the abstract method
            myPig.sleep();  // Call the regular method

            //abClass abClassVar = new abClass();
            abClass abClassVar = new abClassImplement();
            abClassVar.abMethod();
            abClassImplement abClassVar2 = new abClassImplement();
            abClassVar2.otherMethod();

            // interface
            InterfaceClass iClass = new InterfaceClass();
            iClass.show();
            iClass.hide();
            //iClass.other(); // bcz of separate implementation of this method
            IInterfaceClass1 iclassInterface1 = new InterfaceClass();
            IInterfaceClass2 iclassInterface2 = new InterfaceClass();
            iclassInterface1.other();
            //iclassInterface2.other();

            // enum
            EnumClass enumClassVar = new EnumClass();
            Console.WriteLine(enumClassVar.d0);
            Console.WriteLine(enumClassVar.d1);
            Console.WriteLine(enumClassVar.d5);
            Console.WriteLine(enumClassVar.strd1);
            enumClassVar.getNameNumberOfEnum();
            Console.WriteLine("days of meeting" + EnumClass.daysOfMeeting);
            //EnumClass.daysOfMeeting = "tuesday"; // cannot use
            EnumClass.daysOfMeeting = (days)2;
            Console.WriteLine("meeting day updated: " + EnumClass.daysOfMeeting);
            EnumClass.daysOfMeeting = days.friday;
            Console.WriteLine("meeting day updated: " + EnumClass.daysOfMeeting);


            // base; super();
            checkClasses checkParentVar = new checkClasses();
            checkClassChild checkChildVar = new checkClassChild();
            checkClasses checkChildVarRef = new checkClassChild();


            System.String str = "panthee";
            string str2 = "patel";
            Console.WriteLine($"{str}, {str2}");
        }
    }
}