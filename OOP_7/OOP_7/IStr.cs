using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_7
{
    internal interface IStr<T>
    {
        void Add(T i);
        void Remove(T i);
        bool Contains(T i);
        void Print();
    }
}
