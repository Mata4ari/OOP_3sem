using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_17
{
    public interface AbstractFactory
    {
        IMedicalWorker CreateDoctor(string name);
        IMedicalWorker CreateNurse(string name);

    }
}
