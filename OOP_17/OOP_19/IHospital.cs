using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_19
{
    public interface IHospital
    {
        List<IMedicalWorker> Doctors { get; set; }
        List<IMedicalWorker> Nurses { get; set; }
        List<Patient> Patients { get; set; }
        IHospital Clone();
    }
}
