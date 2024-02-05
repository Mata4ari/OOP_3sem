using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_19
{
    public class Patient:IHospitalObserver
    {
        public string Name { get;  }
        public string Password { get; }
        public string Diagnosis { get; set; }
        public string FinalDiagnosis { get; set; }
        public Prescription prescription { get; set; }
        public IUserState State { get; set; }

        public Patient(string name,string password)
        {
            Name = name;
            Password = password;
            prescription = Prescription.NOPRESCRIPTION;
            State = null;
        }

        public void UpdatePrescription(Prescription prescription)
        {
            Console.WriteLine($"Пациент {Name} получил новое предписание: {prescription}");
        }

        public void Process()
        {
            State.UserState(this);
        }
    }
}
