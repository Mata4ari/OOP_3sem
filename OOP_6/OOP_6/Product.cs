using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_6
{
    public abstract class Product:ICloneable
    {
       public  Product() { }
        protected Product(int id)
        {
            Id = id;
        }
       public abstract int Id { get; set; }
        public int Cost { get; set; }
        public string Name { get; set; }
        public int Explotation { get; set; }
        public Devices device { get; set; }

        public abstract object Clone();
        

        public abstract void PrintCategory();
        

    }

    public enum Devices:byte
    {
        Printer,
        PrintMachine,
        Computer,
        Tablet,
        Scaner
    }
}
