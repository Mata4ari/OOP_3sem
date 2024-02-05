using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_17
{
    public class Patient
    {
        public string Name { get;  }
        public string Password { get; }
        public string Diagnosis { get; set; }
        public string FinalDiagnosis { get; set; }
        public Prescription prescription { get; set; }
        
        public Patient(string name,string password)
        {
            Name = name;
            Password = password;
        }

    }
}
