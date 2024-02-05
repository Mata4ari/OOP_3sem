using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_17
{
    public class HospitalDirector
    {
        private readonly IHospitalBuilder builder;
        public HospitalDirector(IHospitalBuilder builder)
        {
            this.builder = builder;
        }
        public void Build()
        {
            builder.BuildDoctors();
            builder.BuildNurses();
            builder.BuildPatients();
        }
    }
}
