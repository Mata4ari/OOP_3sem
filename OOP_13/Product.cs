using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_13
{
    [Serializable]
    public abstract class Product
    {
       public  Product() { }
        public int Cost { get; set; }
        public string Name { get; set; }
       public abstract void PrintCategory();

    }
}
