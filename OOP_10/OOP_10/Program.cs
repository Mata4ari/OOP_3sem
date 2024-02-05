using OOP_2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string[] months = { "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" };
                string n;
                n = Console.ReadLine();
                var result1 = months.Where(i => i.Length == Convert.ToInt32(n)).Select(i => i);
                foreach (var i in result1) { Console.Write(i + " "); }
                Console.WriteLine();

                var result2 = months.Where(i => i == "June" || i == "July" || i == "August" || i == "December" || i == "January" || i == "February")
                    .Select(i => i);
                foreach (var i in result2) { Console.Write(i + " "); }
                Console.WriteLine();

                var result3 = from i in months
                              orderby i
                              select i;
                foreach (var i in result3) { Console.Write(i + " "); }
                Console.WriteLine();

                var result4 = from i in months
                              where i.Length >= 4
                              where i.Contains("u")
                              select i;
                foreach (var i in result4) { Console.Write(i + " "); }
                Console.WriteLine();

                List<Abiturient> students = new List<Abiturient>{ new Abiturient("Vasiliy", "Fadeev", "Andreevich",new int[]{5, 4, 7}),
                    new Abiturient("Mila", "Alilueva", "Evgenievna",new int[]{2, 4, 3}),
                    new Abiturient("Leonid", "Jarkovich", "Alexandrovich",new int[]{6, 4, 6}),
                    new Abiturient("Eva", "Cvetochkina", "Antonovna",new int[]{1, 9, 9}),
                    new Abiturient("Lev", "Shkafov", "Viktorovich",new int[]{10, 8, 7}),
                    new Abiturient("Ilia", "Murovedov", "Nikitich",new int[]{7, 7, 7}),
                    new Abiturient("Svetlana", "Karamuzova", "Viktorovna",new int[]{5, 9, 8}),
                    new Abiturient("Svetoslav", "Solnishko", "Genadievich",new int[]{5, 5, 3}),
                    new Abiturient("Miraslav", "Nikitenko", "Georgievich",new int[]{4, 4, 4}),
                    new Abiturient("Sasha", "Krilov", "Otcevich",new int[]{10, 10, 10})
            };

                var result5 = students.Where(i => i.Grades.Contains(0) || i.Grades.Contains(1) || i.Grades.Contains(2) || i.Grades.Contains(3))
                    .Select(i => i);
                foreach (var i in result5)
                {
                    Console.Write(i.Surname + " ");
                    foreach (var k in i.Grades)
                    {
                        Console.Write(k + " ");
                    }
                    Console.Write("; ");
                }
                Console.WriteLine();

                n = Console.ReadLine();
                var result6 = students.Where(i => i.Grades.Sum() > Convert.ToInt32(n))
                    .Select(i => i);
                foreach (var i in result6)
                {
                    Console.Write(i.Surname + " ");
                    foreach (var k in i.Grades)
                    {
                        Console.Write(k + " ");
                    }
                    Console.Write("; ");
                }
                Console.WriteLine();

                n = Console.ReadLine();
                var result7 = students.Where(i => i.Grades[Convert.ToInt32(n) - 1] == 10)
                    .Select(i => i);
                foreach (var i in result7)
                {
                    Console.Write(i.Surname + " ");
                    foreach (var k in i.Grades)
                    {
                        Console.Write(k + " ");
                    }
                    Console.Write("; ");
                }
                Console.WriteLine();

                var result8 = students.OrderBy(i => i.Surname)
                    .Select(i => i);
                foreach (var i in result8)
                {
                    Console.Write(i.Surname + " ");
                    Console.Write("; ");
                }
                Console.WriteLine();

                var result9 = students.OrderBy(i => i.Grades.Sum())
                    .Take(4)
                    .Select(i => i);
                foreach (var i in result9)
                {
                    Console.Write(i.Surname + " ");
                    foreach (var k in i.Grades)
                    {
                        Console.Write(k + " ");
                    }
                    Console.Write("; ");
                }
                Console.WriteLine();

                var result10 = students.Where(i => i.Grades.Sum() > 10)
                    .OrderByDescending(i => i.Grades.Sum())
                    .GroupBy(i => i.Grades.Sum())
                    .Take(3)
                    .Select(i => i);
                foreach (var i in result10)
                {

                    foreach (var j in i)
                    {
                        Console.Write(j.Surname + " ");
                    }
                    Console.Write(i.Key);
                    Console.Write("; ");
                }
                Console.WriteLine();

                var result11 = students.Join(new int[] { 5, 6, 7, 8 },
                    w => w.Surname.Length,
                    q => q,
                    (w, q) => new
                    {
                        name = w.Surname,
                        id = q,
                    });
                foreach (var item in result11)
                    Console.WriteLine(item);
            }
            catch(Exception ex) 
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
