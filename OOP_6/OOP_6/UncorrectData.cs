using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace OOP_6
{
    internal class UncorrectData:Exception
    {
        public int value { get; }
        public UncorrectData(int d)
        {
            value = d;
        }
        
    }
}
