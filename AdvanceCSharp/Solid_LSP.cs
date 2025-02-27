using System;

//// wrong approach
//public class Rectangle
//{
//    public virtual int Width { get; set; }
//    public virtual int Height { get; set; }

//    public int GetArea()
//    {
//        return Width * Height;
//    }
//}

//// Square is a Rectangle (Inheritance)
//public class Square : Rectangle
//{
//    public override int Width
//    {
//        set { base.Width = base.Height = value; }
//    }

//    public override int Height
//    {
//        set { base.Width = base.Height = value; }
//    }
//}

//// Usage
//class Program
//{
//    static void Main()
//    {
//        Rectangle rect = new Square();
//        rect.Width = 5;
//        rect.Height = 10; // Not behaving as expected!

//        Console.WriteLine("Area: " + rect.GetArea()); // Expected: 5*10=50, but gives 10*10=100!
//    }
//}


// better approach
// Step 1: Define a base class with a GetArea method
public abstract class Shape
{
    public abstract int GetArea();
}

// Step 2: Rectangle class follows LSP
public class Rectangle : Shape
{
    public int Width { get; set; }
    public int Height { get; set; }

    public override int GetArea()
    {
        return Width * Height;
    }
}

// Step 3: Square class follows LSP
public class Square : Shape
{
    public int Side { get; set; }

    public override int GetArea()
    {
        return Side * Side;
    }
}

//// Usage
//class Program
//{
//    static void Main()
//    {
//        Shape rectangle = new Rectangle { Width = 5, Height = 10 };
//        Console.WriteLine("Rectangle Area: " + rectangle.GetArea()); // Output: 50

//        Shape square = new Square { Side = 5 };
//        Console.WriteLine("Square Area: " + square.GetArea()); // Output: 25
//    }
//}
