using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*IHospital hospital = new Hospital();
            IMedicalWorker doctorAdapter = new MedicalWorkerAdapter(hospital);
            doctorAdapter.PerformProcedure("Ингаляция");


            IMedicalWorker worker = new Nurse("Masha");
            worker.PerformProcedure("Ингаляция");
            worker.ProvideMedicine("Ревит");

            worker = new MedicalDecorator(worker);
            worker.PerformProcedure("Укол");
            worker.ProvideMedicine("Цитрамон");


            
            Nurse nurse = new Nurse("Natasha");
            ((Hospital)hospital).AddNurse(nurse);
            Patient patient = new Patient("Misha", "234567");
            ((Hospital)hospital).PrescribeAntibiotiki(patient,nurse);


            Hospital newhospital = new Hospital();
            Doctor doc = new Doctor("Oleg");
            newhospital.AddDoctor(doc);
            newhospital.Registration("Pete", "092082");
            Patient patient1 = newhospital.SingIn("Pete", "092082");

            newhospital.RegisterObserver(patient1);

            newhospital.DetermineDiagnosis(patient1);
            newhospital.GivePrescription(patient1);
            newhospital.SingOut("Pete");*/

            var val = Tuple.Create(16, 'g');
            
            (string , int ) tup = ("dksmf", 16);
            Console.WriteLine(tup.Item2);`
            People peopl= new People {name="ghsd",age=17 };
            Console.WriteLine(peopl.name);
            object obj =new object();
            obj.
        }
        public class People
        {
            public string name;
            public int age;
            ~People() { Console.WriteLine("fgwhaskl;c"); }
        }
    }
}
