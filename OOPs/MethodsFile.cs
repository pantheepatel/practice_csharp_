namespace OOPs
{
    public class MethodsFile
    {
        // if not program.cs
        //public static void Main(string[] args)
        //{
        //    Console.WriteLine("Into new Project: OOPs");

        //    // topic - methods
        //    //public static void Main()
        //    //static means that the method belongs to the Program class and not an object of the Program class.
        //    MethodsFile.MyMethod("Panthee", 20); // this passed value is called argument
        //    MethodsFile.MyMethod(); // use of default parameters
        //    MethodsFile.MyMethod(age: 16, name: "Nehee Patel");
        //}
        public static void MyMethod(string name = "user", int age = 0) // name is called parameter of MyMethod
        {
            Console.WriteLine();
            Console.WriteLine("** File MethodsFile **");
            Console.WriteLine("Hello {0}! with age {1}", name, age);


        }
    }

}
