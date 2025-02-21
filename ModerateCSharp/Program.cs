using ModerateCSharp;

namespace moderateCSharp
{
    class ModerateCSharp
    {
        static void Main(string[] args)
        {

            // 20-02
            //// arrays
            //ArraysClass.ArraysClassMethod();
            //ArraysClass.MultiArrayClassMethod();

            //// deconstructor
            //Person person = new("Panthee", 20);
            //(string personName, int personAge) = person; // Using deconstruction
            //Console.WriteLine($"Name: {personName}, Age: {personAge}");

            //// structure
            //StructC structCVar1;
            //structCVar1.i = 0; // if not called implicit con with new keyword have to assign value for each
            //structCVar1.StructCMethod();
            //
            //StructC structCVar2 = new StructC(); // calling implicit con which will initialize values for fields  
            //structCVar1.StructCMethod();
            //
            //StructC structCVar3 = new StructC(2);


            // 21-02
            // looping, branching, jumping(goto), switching

            //// exceptions
            //ExceptionClass exceptionObj1 = new();
            //exceptionObj1.ExceptionClassMethod();
            //exceptionObj1.ExceptionCustomMethod();


            //// clearing memory for unmanaged resources
            //// 1st way to dispose using garbage collector
            //// 2nd way of clearing open resource - manually disposing object
            //FileHandler handler = new FileHandler("TextFile1.txt");
            //handler.Dispose();  // Explicitly releasing resources

            //// 3rd way of clearing open resource - using keyword
            //using (FileStream fs = new FileStream("TextFile1.txt", FileMode.OpenOrCreate))
            //{
            //    Console.WriteLine("File opened.");
            //}  // fs.Dispose() is called automatically here
            //Console.WriteLine("File closed.");

        }
    }
}