using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_17
{
    public interface IHospitalBuilder
    {
        void BuildNurses();
        void BuildDoctors();
        void BuildPatients();
        Hospital GetHospital();
    }
}
