using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_5
{
    internal partial class Laboratory
    {
        public void Clear()
        {
            arr.Clear();
        }

        public void Print()
        {
            foreach (var t in arr)
            {
                Console.WriteLine(t.ToString() + " ");
            }
            Console.WriteLine();
        }
    }
}
