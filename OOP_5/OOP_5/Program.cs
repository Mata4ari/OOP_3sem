using OOP_4;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Laboratory lab=new Laboratory();
            lab.Add(new PrintMachine(177,5));
            lab.Add(new Scaner(255,1));
            lab.Add(new Tablet(114,7));
            lab.Add(new Computer(17,3));
            lab.Add(new Printer(33,3));
            lab.Add(new Printer(222,4));
            lab.Print();

            Controller controller = new Controller();
            controller.OrderByCost(lab);
            lab.Print();
            controller.Quality(lab);
            Console.WriteLine();
            controller.CheakDate(lab, 3);

            Scaner scaner =new Scaner(1000,15);
            Object clone = scaner.Clone();
            Console.WriteLine("\n"+clone.ToString());
        }
    }
}
