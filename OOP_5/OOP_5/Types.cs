using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_5
{
    struct ProductType
    {
        static ProductType()
        {

        }
        public ProductType(int c,string n) 
        {
            name = n;
            col = c;
        }
        public string name { get; set; }
        public int col { get; set; }
    }
    class Types 
    {
        public ProductType[] item= { new ProductType(0, "Printer"), new ProductType(0, "Computer"), new ProductType(0, "PrintMachine"), new ProductType(0, "Tablet"), new ProductType(0, "Scaner") };
        
    }
}
