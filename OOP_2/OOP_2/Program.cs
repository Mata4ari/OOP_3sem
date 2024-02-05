using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_2
{
    internal class Program
    {

        static void Main(string[] args)
        {
            int[] m = new int[] {5,5,5,5,5 };
            int[] m2 = new int[] { 4,4,4,3,2 };
            int[] m3 = new int[] { 5, 4,2,2,2 };
            Abiturient[] abiturients = new Abiturient[5];
            abiturients[0]=new Abiturient( "Alex","Veseli","Olegovich",m, "555", "364322");
            abiturients[1] = new Abiturient("Maksim", "Grustni", "Vladimirovich");
            abiturients[2] = abiturients[0].getCopy(13, abiturients[0]);
            abiturients[3] = new Abiturient("Vadim", "Veseli", "Olegovich", m2, "555", "364322");
            abiturients[4] = new Abiturient("Evgeniy", "Veseli", "Olegovich", m3, "555", "364322");
            abiturients[1].Surname = "Mihalov";
            int k = abiturients[2].Id;
            int l;
            int k1 = 3;
            abiturients[3].getMark(out l, 2);
            foreach (var item in abiturients)
            {
                item.Neut(ref k1);
            }
            Console.WriteLine("-------------------------");
            foreach (var item in abiturients)
            {
                item.GreaterThan(4);
            }
            Abiturient.getInfo();
            Console.WriteLine( abiturients[0].Equals( abiturients[1]));
            Console.WriteLine(abiturients[0].GetHashCode());
            Console.WriteLine(abiturients[0].ToString());
            var people = new { name="Artem", surname="Navicki", lastname="Alexeevich" };
            Console.WriteLine(people.name+" "+people.surname+" "+people.lastname);
            
        }
    }

}
