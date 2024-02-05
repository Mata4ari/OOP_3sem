using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_17
{
    public class MedicalWorkerFactory : AbstractFactory
    {
        public IMedicalWorker CreateDoctor(string name)
        {
            return new Doctor(name);
        }

        public IMedicalWorker CreateNurse(string name)
        {
            return new Nurse(name);
        }
    }
}
