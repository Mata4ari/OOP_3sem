using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_4
{
    public abstract class Product
    {
       public  Product() { }
        public Product(int id)
        {
            Id = id;
        }
       public abstract int Id { get; set; }
        public int Cost { get; set; }
        public string Name { get; set; }
       public abstract void PrintCategory();

    }
}
