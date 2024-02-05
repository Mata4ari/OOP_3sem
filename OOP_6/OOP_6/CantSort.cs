using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_6
{
    internal class CantSort:Exception
    {
        public int value { get; }
        public CantSort(int idx)
        {
            value = idx;
        }
    }
}
