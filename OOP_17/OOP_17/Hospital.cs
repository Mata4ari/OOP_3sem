using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace OOP_17
{
    public enum Prescription
    {
        PROCEDURE,
        MEDICINE,
        OPERATION,
        REFUSE
    }
    public  class Hospital:IHospital
    {
        public List<IMedicalWorker> Doctors { get; set; }
        public List<IMedicalWorker> Nurses { get; set; }
        public List<Patient> Patients { get; set; }

        public Hospital()
        {
            Doctors = new List<IMedicalWorker>();
            Nurses = new List<IMedicalWorker>();
            Patients = new List<Patient>();
        }
        private Hospital(Hospital donor)
        {
            Doctors=new List<IMedicalWorker>(donor.Doctors);
            Nurses=new List<IMedicalWorker>(donor.Nurses);
            Patients=new List<Patient>(donor.Patients);
        }

        public void AddDoctor(Doctor doctor)
        {
            Doctors.Add(doctor);
        }

        public void AddNurse(Nurse nurse)
        {
            Nurses.Add(nurse);
        }

        public void Registration(string name,string password)
        {
            if(Patients.Select(i=>i.Name).Contains(name))
            {
                Console.WriteLine("Пациент уже зарегистрирован");
            }
            {
                Patient patient = new Patient(name, password);
                Patients.Add(patient);
            }
        }
        public Patient SingIn(string name,string password)
        {
            if(!Patients.Select(i=>i.Name).Contains(name))
            {
                Console.WriteLine("Пациент не был зарегистрирован");
            }
            else
            {

                if (Patients.Where(i => i.Name == name).First().Password == password)
                    return Patients.Where(i => i.Name == name).First();
                else
                {
                    Console.WriteLine("Неверный пароль");
                }
            }
            return null;
        }

        public void DetermineDiagnosis(Patient patient)
        {
            patient.Diagnosis =((Doctor)Doctors[0]).DetermineDiagnosis();
        }
        public void GivePrescription(Patient patient)
        {
            patient.prescription = ((Doctor)Doctors[0]).GivePrescription();
        }
        public void PerformPrescription(Patient patient)
        {
            if(patient.prescription == Prescription.REFUSE)
            {

            }
            if (patient.prescription == Prescription.OPERATION)
            {
                ((Doctor)Doctors[0]).PerformOperation("по извлечению камня из почки");
            }
            if (patient.prescription == Prescription.MEDICINE)
            {
                Nurses[0].ProvideMedicine("Ревит");
            }
            if (patient.prescription == Prescription.PROCEDURE)
            {
                Nurses[0].PerformProcedure("ингаляции");
            }
        }
        public void SingOut(string name)
        {
            if (!Patients.Select(i=>i.Name).Contains(name))
            {
                Console.WriteLine("Такой пациент не был зарегистрирован");
            }
            {
                Console.WriteLine("Вы вышли из из системы");
            }
        }
        public void CheckInfo(Patient patient)
        {
            Console.WriteLine(patient.Name);
            Console.WriteLine(patient.Diagnosis);
            Console.WriteLine(patient.prescription);
            Console.WriteLine(patient.FinalDiagnosis);
        }
        public void RefusePrescription(Patient patient)
        {
            patient.prescription = Prescription.REFUSE;
        }
        public void ReconsoderDiagnosis(Patient patient)
        {
            patient.Diagnosis = ((Doctor)Doctors[0]).DetermineDiagnosis();
        }

        public void DischargePatient(Patient patient)
        {
            patient.FinalDiagnosis = ((Doctor)Doctors[0]).DetermineFinalDiagnosis();
        }
        public override string ToString()
        {
            string str="";
            str = $"Doctors: {Doctors.Count}\nNurses: {Nurses.Count}\nPatients: {Patients.Count}\n";
            foreach (Patient patient in Patients) { str += patient.Name + "\n"; }
            return str;
        }
        public IHospital Clone()
        {
            return new Hospital(this);
        }
    }
}
