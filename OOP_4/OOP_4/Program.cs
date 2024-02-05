using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PrintMachine A = new PrintMachine();
            A.chip.getChipId();
            A.Cost = 755;
            A.Name = "Lenovo";
            Console.WriteLine(A.ToString());
            PrintMachine B = new PrintMachine();
            Console.WriteLine(B.Equals(A));
            Product C=new PrintMachine();
            C.PrintCategory();
            ITechnique D=new Scaner();
            D.PrintCategory();

            if (D is Product product)
            {
                product.PrintCategory();
            }
            ITechnique tech = C as ITechnique;
            if(tech!=null)
            {
                tech.PrintCategory();
            }
            ITechnique E = new Scaner();
            E.Start();
            E.Stop();
            C.Cost = 555;
            C.Name = "LE-5433";
            Console.WriteLine( C.ToString());
            ITechnique[] technique = { new Scaner(), new Tablet(), new Computer(), new Printer() };
            Printer printer = new Printer();
            printer.IAmPrinting(technique[0]);
            printer.IAmPrinting(technique[1]);
            printer.IAmPrinting(technique[2]);
            printer.IAmPrinting(technique[3]);


            Tablet tab = new Tablet(17);
            Console.WriteLine(tab.Id);
        }
    }
}
