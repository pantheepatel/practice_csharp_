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
        }
    }
}