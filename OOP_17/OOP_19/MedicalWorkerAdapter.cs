using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_19
{
    public class MedicalWorkerAdapter:IMedicalWorker
    {
        private readonly IHospital _hospital;

        public MedicalWorkerAdapter(IHospital hospital)
        {
            _hospital = hospital;
        }

        public void PerformProcedure(string procedure)
        {
            Console.WriteLine("Врач выполнил процедуру: " + procedure);
        }

        public void ProvideMedicine(string medicine)
        {
            Console.WriteLine("Врач выдал лекарство: " + medicine);
        }
    }
}
