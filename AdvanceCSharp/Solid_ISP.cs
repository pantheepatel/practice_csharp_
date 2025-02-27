//// not good approach
//// Interface with too many responsibilities
//public interface IMachine
//{
//    void Print();
//    void Scan();
//    void Fax();
//}

//// Simple Printer (Does not support Scan & Fax)
//public class SimplePrinter : IMachine
//{
//    public void Print()
//    {
//        Console.WriteLine("Printing document...");
//    }

//    public void Scan()
//    {
//        throw new NotImplementedException(); // ❌ Violates ISP
//    }

//    public void Fax()
//    {
//        throw new NotImplementedException(); // ❌ Violates ISP
//    }
//}

//// Usage
//class Program
//{
//    static void Main()
//    {
//        IMachine printer = new SimplePrinter();
//        printer.Print();
//        printer.Scan(); // ❌ Throws error, not needed for SimplePrinter
//    }
//}

// better approach: split the interface into smaller, more specific interfaces.
// Step 1: Define small and specific interfaces
public interface IPrinter
{
    void Print();
}

public interface IScanner
{
    void Scan();
}

public interface IFax
{
    void Fax();
}

// Step 2: Implement specific interfaces

// A Simple Printer only implements IPrinter
public class SimplePrinter : IPrinter
{
    public void Print()
    {
        Console.WriteLine("Printing document...");
    }
}

// A Multifunction Printer implements all three interfaces
public class MultiFunctionPrinter : IPrinter, IScanner, IFax
{
    public void Print()
    {
        Console.WriteLine("Printing document...");
    }

    public void Scan()
    {
        Console.WriteLine("Scanning document...");
    }

    public void Fax()
    {
        Console.WriteLine("Faxing document...");
    }
}

//// Usage
//class Program
//{
//    static void Main()
//    {
//        IPrinter printer = new SimplePrinter();
//        printer.Print();

//        MultiFunctionPrinter mfp = new MultiFunctionPrinter();
//        mfp.Print();
//        mfp.Scan();
//        mfp.Fax();
//    }
//}
