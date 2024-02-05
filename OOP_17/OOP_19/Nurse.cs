using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_19
{
    public class Nurse:IMedicalWorker
    {
        public string Name {  get; set; }
        public Nurse(string name)
        {
            Name = name;
        }
        public void PerformProcedure(string procedure)
        {
            Console.WriteLine("Медсестра выполнила процедуру: " + procedure);
        }

        public void ProvideMedicine(string medicine)
        {
            Console.WriteLine("Медсестра выдала лекарство: " + medicine);
        }
    }
}
