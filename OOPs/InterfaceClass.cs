using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPs
{
    interface IInterfaceClass1
    {
        //int show();
        void hide();
        void other();
    }
    interface IInterfaceClass2
    {
        void show();
        void hide();
        void other();
    }
    class InterfaceClass: IInterfaceClass1,IInterfaceClass2
    {
        //public int show()
        //{
        //    Console.WriteLine("private int show");
        //    return 0;
        //}
        public void show()
        {
            Console.WriteLine("void other");
        }
        public void hide()
        {
            Console.WriteLine("void hide");
        }
        void IInterfaceClass1.other()
        {
            Console.WriteLine("void other for interface1");
        }
        void IInterfaceClass2.other()
        {
            Console.WriteLine("void other for interface2");
        }

    }
}
