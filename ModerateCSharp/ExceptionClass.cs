namespace ModerateCSharp
{
    class CustomExceptionClass : Exception
    {
        public override string Message
        {
            get{
                return "String Cannot be Null";
            }
        }
        public CustomExceptionClass()
        {
            Console.WriteLine("in custom Exception: ");
        }
    }
    class ExceptionClass
    {
        public void ExceptionCustomMethod()
        {
            string? str_ = null;
            try
            {
                if (str_ == null)
                {
                    throw new CustomExceptionClass();
                }
            }catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        public void ExceptionClassMethod()
        {
            int?[] arr = {19, 2, 75, 52, null};
            try
            {
                for (int i = 0; i < arr.Length - 1; i++)
                {
                    Console.WriteLine(arr[i] / arr[i + 1]);
                }
            }
            // Catch block for invalid array access
            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine("1. An Exception has occurred : {0}", e.Message);
            }
            // Catch block for attempt to divide by zero
            catch (DivideByZeroException e)
            {
                Console.WriteLine("2. An Exception has occurred : {0}", e.Message);
            }
            // Finally block
            // Will execute irrespective of the above catch blocks
            finally
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    Console.Write(" {0}", arr[i]);
                    Console.WriteLine();
                }
            }
        }
    }
}
