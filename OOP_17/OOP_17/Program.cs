using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var factory = new MedicalWorkerFactory();
            var doctor = factory.CreateDoctor("Oleg");
            var nurse = factory.CreateNurse("Elena");
            Hospital hospital = new Hospital();
            hospital.AddDoctor((Doctor)doctor);
            hospital.AddNurse((Nurse)nurse);
            hospital.Registration("Pete","092082");
            Patient patient = hospital.SingIn("Pete", "092082");
            hospital.DetermineDiagnosis(patient);
            hospital.GivePrescription(patient);
            //hospital.RefusePrescription(patient);
            hospital.ReconsoderDiagnosis(patient);
            hospital.PerformPrescription(patient);
            hospital.DischargePatient(patient);
            hospital.CheckInfo(patient);
            hospital.SingOut("Pete");

            List<IMedicalWorker> doctors = new List<IMedicalWorker> { factory.CreateDoctor("Oleg"), factory.CreateDoctor("Evgeniy"), factory.CreateDoctor("Svetlana") };
            List<IMedicalWorker> nurses = new List<IMedicalWorker> { factory.CreateNurse("Elena"), factory.CreateNurse("Natasha"), factory.CreateNurse("Alina") };
            List<Patient> patients = new List<Patient>
            {
                new Patient("Maks","fghj"),
                new Patient("Evgeniy","123456"),
                new Patient("Misha","tfirdc"),
                new Patient("Lesha","d686rf"),
                new Patient("Masha","tdfrd")
            };

            var builder = new HospitalBuilder(patients, doctors, nurses);
            var director = new HospitalDirector(builder);
            director.Build();
            var newHospital = builder.GetHospital();
            Console.WriteLine(newHospital);

            SettingsSingleton.Instance.FontStyle = "Calibri";
            Console.WriteLine(SettingsSingleton.Instance.FontStyle+"\n");

            var cloneHospital = newHospital.Clone();
            Console.WriteLine(cloneHospital);
        }
    }
}
