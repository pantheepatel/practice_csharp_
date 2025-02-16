public class UserInput
{
    public static string UserInputMethodFname()
    {
        Console.WriteLine();
        Console.WriteLine("** File UserInput **");
        Console.Write("Enter your first name: ");
        string fname = Convert.ToString(Console.Read());
        //int fname = Convert.ToInt32(Console.ReadLine());
        //Console.WriteLine("your fname : " + fname);
        return fname;
    }
    public string UserInputLname()
    {
        Console.Write("Enter your last name : ");
        string lname;
        //Console.WriteLine("entered last name: " + lname);
        return lname = Console.ReadLine();
    }

}
