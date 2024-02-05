using OOP_6;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace OOP_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Laboratory lab = new Laboratory();
                //lab.Add(new PrintMachine(177, 16));
                lab.Add(new Scaner(255, 1));
                lab.Add(new Tablet(114, 7));
                lab.Add(new Computer(17, 3));
                lab.Add(new Printer(33, 3));
                lab.Add(new Printer(222, 4));
                try
                {
                    //lab.Add(null);
                }
                catch (NullPtr e)
                {
                    Console.WriteLine("Нельзя добавить несуществующий объект " + e.Source + " в контейнер");
                    Console.WriteLine(e.TargetSite);
                    Console.WriteLine(e.StackTrace);
                    throw;
                }
                lab.Print();
                Controller controller = new Controller();
                lab.Print();
                controller.Quality(lab);
                Console.WriteLine();
                controller.CheakDate(lab, 3);
            }
            catch (UncorrectData e)
            {
                Console.WriteLine("Некорректно заданное значение(" + e.value + ") срока эксплуатации ");
                Console.WriteLine(e.TargetSite);
                Console.WriteLine(e.StackTrace);
            }
            catch (CantSort e) when (e.value <0 )
            {
                Console.WriteLine("Невозможно отсортировать. Неворно значение цены под индексом:" + e.value);
                Console.WriteLine(e.TargetSite);
                Console.WriteLine(e.StackTrace);
            }
            catch (Exception e)
            {
                Console.WriteLine("Вызван общий обработчик исключений");
                Console.WriteLine(e.TargetSite);
                Console.WriteLine(e.StackTrace);
            }
            try { 

                Laboratory laboratory = new Laboratory();
                laboratory.Add(new Scaner(255, 1));
                laboratory.Add(new Tablet(114, 7));
                Controller controller = new Controller();

                //laboratory.arr[1].Cost = -7;
                controller.OrderByCost(laboratory);
                Scaner scaner = new Scaner(1000, 14);
                Object clone = scaner.Clone();
                Console.WriteLine("\n" + clone.ToString());
                int a = -7;
                //Debug.Assert(a >= 0,"Number cannot be negative");
            }
            catch (UncorrectData e)
            {
                Console.WriteLine("Некорректно заданное значение("+e.value+") срока эксплуатации ");
                Console.WriteLine(e.TargetSite);
                Console.WriteLine(e.StackTrace);
            }
            catch (CantSort e)
            {
                Console.WriteLine("Невозможно отсортировать. Неворно значение цены под индексом:"+e.value);
                Console.WriteLine(e.TargetSite);
                Console.WriteLine(e.StackTrace);
            }
            catch(Exception e)
            {
                Console.WriteLine("Вызван общий обработчик исключений");
                Console.WriteLine(e.TargetSite);
                Console.WriteLine(e.StackTrace);
            }
            finally
            {
                Console.WriteLine("Программа завершила работу");
            }
        }
    }
}
