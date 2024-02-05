using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_19
{
    public class Doctor:IMedicalWorker
    {
        string Name { get; set; }
        public Doctor(string name)
        {
            Name = name;
        }

        public string DetermineDiagnosis()
        {
            return "Диагноз: некоторый диагноз";
        }
        public string DetermineFinalDiagnosis()
        {
            return "Диагноз: финальный диагноз";
        }

        public Prescription GivePrescription()
        {
            Random random = new Random();
            Prescription prescription = new Prescription();
            int x = random.Next(0,3);
            if(x == 0) { prescription = Prescription.PROCEDURE; }
            if (x == 1) { prescription = Prescription.MEDICINE; }
            if (x == 2) { prescription = Prescription.OPERATION; }
            return prescription;
        }
        public void PerformOperation(string operation)
        {
            Console.WriteLine("Доктор выполнил операцию: " + operation);
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
