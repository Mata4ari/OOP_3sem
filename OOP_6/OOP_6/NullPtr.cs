using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_6
{
    internal class NullPtr:Exception
    {
        public NullPtr() 
        {
            Source = "Product";
        }
    }
}
