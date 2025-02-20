using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModerateCSharp
{
    struct StructC
    {
        public int i;
        public void StructCMethod()
        {
            Console.WriteLine("into structCMethod");
        }
        public StructC(int paramI)
        {
            Console.WriteLine("in struct with param " + paramI);
        }
    }
}
