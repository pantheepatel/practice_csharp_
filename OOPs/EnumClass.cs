using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPs
{
    public enum days 
    {
        //monday, tuesday, wednesday, thursday, friday
        monday = 1, tuesday = 20, wednesday, thursday = 21, friday = 25
        //monday=10, tuesday, wednesday, thursday, friday
    }


    //public enum days : byte
    //{
    //    monday = 1, tuesday = 20, wednesday, thursday = 21, friday = 25
    //}
    class EnumClass
    {
        public days d0 = 0;
        public days d1 = (days)1;
        public days d5 = (days)5;
        public days strd1 = days.monday;

        public void getNameNumberOfEnum()
        {
            foreach (string i in Enum.GetNames(typeof(days))) { Console.WriteLine(i); }
            foreach (int i in Enum.GetValues(typeof(days))) { Console.WriteLine(i + " " + (days)i); }
        }

        public static days daysOfMeeting { get; set; } = (days)1;
        //public static days daysOfMeeting { get; set; } = (days)11;


    }
}
