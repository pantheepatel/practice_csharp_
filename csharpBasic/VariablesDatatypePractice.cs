namespace basicHello
{
    class VariablesDatatypePractice
    {
        public static void variablesMethod()
        {
            Console.WriteLine();
            Console.WriteLine("** File VariablesDatatypePractice **");
            const int int_ = 10;
            int int_1 = -1, int_2 = 10;
            Console.WriteLine("my var for int with val: " + int_);
            // below will give error, as you can't change the value of a constant
            // int_ = 20;

            bool bool_ = true;
            // can not convert from 'bool' to 'char' implicitly
            //char boolChar = bool_;

            // type conversion methods
            Console.WriteLine(Convert.ToDouble(int_1));
            //Console.WriteLine(Convert.ToString(int_1));
            //Console.WriteLine(Convert.ToBoolean(int_1));
            //Console.WriteLine(Convert.ToChar(int_1));
            //Console.WriteLine(Convert.ToDecimal(int_1));
            //Console.WriteLine(Convert.ToInt16(int_1));
            //Console.WriteLine(Convert.ToUInt16(int_1));
            //Console.WriteLine(Convert.ToInt32(int_1));
            //Console.WriteLine(Convert.ToUInt32(int_1));
            //Console.WriteLine(Convert.ToInt64(int_1));
            //Console.WriteLine(Convert.ToUInt64(int_1));
            //Console.WriteLine(Convert.ToSingle(int_1));
            //Console.WriteLine(Convert.ToByte(int_1));
            //Console.WriteLine(Convert.ToSByte(int_1));
            Console.WriteLine("my var for double with val: " + int_1);
        }
    }
}