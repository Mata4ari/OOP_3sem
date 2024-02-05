using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_19
{
    public abstract class MedicalWorkerDecorator : IMedicalWorker
    {
        protected IMedicalWorker _medicalworker;

        public MedicalWorkerDecorator(IMedicalWorker worker)
        {
            _medicalworker = worker;
        }

        public virtual void PerformProcedure(string procedure)
        {
             _medicalworker.PerformProcedure("Укол");
        }

        public virtual void ProvideMedicine(string medicine)
        {
             _medicalworker.ProvideMedicine("Аспоркам");
        }
    }
}
