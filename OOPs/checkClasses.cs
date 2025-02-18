using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPs
{
    class checkClasses
    {
        protected int value1;
        internal int value2;
        private int value3;
        protected internal int value4;
        protected private int value5;
    }
    class checkClassChild : checkClasses
    {
        public void show1()
        {
            value1 = 1;
            value2 = 1;
            //value3 = 1;
            value4 = 1;
            value5 = 1;
        }
    }
}
