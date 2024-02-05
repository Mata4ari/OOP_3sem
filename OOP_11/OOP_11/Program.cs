using OOP_2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.IO;

namespace OOP_11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string filePath = "A.json";
                Type t = typeof(Abiturient);
                Console.WriteLine(Reflector.GetAssemblyName(t, filePath));
                Reflector.GetConstructors(t, filePath);
                Reflector.GetMethods(t, filePath);
                Reflector.GetFields(t, filePath);
                Reflector.GetInterfaces(t, filePath);
                Console.WriteLine();
                string a = "";
                Reflector.GetMethodByParm(t, a);
                Reflector.Invoke(new Abiturient(), "getFIO");
                Reflector.InvokeRandom(new Abiturient(), "getFIO");

                Console.WriteLine(Reflector.Create<Abiturient>(new object[] { "Petr", "Petrov", "Vasilevich", "", "" }).Surname);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
