using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_19
{
    public class MedicalDecorator : MedicalWorkerDecorator
    {
        public MedicalDecorator(IMedicalWorker worker) : base(worker) { }

        public override void PerformProcedure(string procedure)
        {
            Console.WriteLine("Врач выполнил процедуру: " + procedure);
        }

        public override void ProvideMedicine(string medicine)
        {
            Console.WriteLine("Врач выдал лекарство: " + medicine);
        }
    }
}
