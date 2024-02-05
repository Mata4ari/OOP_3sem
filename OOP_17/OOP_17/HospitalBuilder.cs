using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_17
{
    public class HospitalBuilder:IHospitalBuilder
    {
        private Hospital hospital;
        private readonly IEnumerable<Patient> patients;
        private readonly IEnumerable<IMedicalWorker> doctors;
        private readonly IEnumerable<IMedicalWorker> nurses;
        public HospitalBuilder(IEnumerable<Patient> patients, IEnumerable<IMedicalWorker> doctors, IEnumerable<IMedicalWorker> nurses)
        {
            this.patients = patients;
            this.doctors = doctors;
            this.nurses = nurses;
            hospital = new Hospital();
        }

        public void BuildNurses()
        {
            hospital.Nurses = new List<IMedicalWorker>(nurses);
        }

        public void BuildDoctors()
        {
            hospital.Doctors = new List<IMedicalWorker>(doctors);
        }

        public void BuildPatients()
        {
            hospital.Patients = new List<Patient>(patients);
        }

        public Hospital GetHospital()
        {
            Hospital hospital = this.hospital;
            return hospital;
        }
    }
}
