using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_2
{
    internal partial class Abiturient
    {
        public Abiturient getCopy(int id, Abiturient A)
        {
            Abiturient B = new Abiturient(id);
            ++count;
            B.name = A.name;
            B.surname = A.surname;
            B.lastname = A.lastname;
            B.adress = A.adress;
            B.telnumber = A.telnumber;
            B.grades = A.grades;
            return B;
        }

        public void Neut(ref int n)
        {
            if (grades == null)
                return;
            foreach (var item in this.grades)
            {
                if (item < n)
                {
                    Console.WriteLine(id + " " + name + " " + surname + " " + lastname);
                    return;
                }
            }
        }
        public void GreaterThan(int n)
        {
            if (grades == null)
                return;
            int x = 0, i = 0;
            foreach (var item in this.grades)
            {
                x += item;
                i++;
            }
            x = x / i;
            if (x > n)
            {
                Console.WriteLine(id + " " + name + " " + surname + " " + lastname);
            }
        }

        public void getMark(out int x, int n)
        {
            if (grades == null)
            {
                x = 0;
                return;
            }
            x = grades[n];
        }

        public static void getInfo()
        {
            Console.WriteLine("count =" + count);
            Console.WriteLine("postIndex =" + postIndex);
        }
        public override bool Equals( object obj1)
        {
            if (this.GetType()!=obj1.GetType())
                return false;
            if(obj1 == null) return false;
            return true;
        }
        public override int GetHashCode()
        {
            int x = Abiturient.postIndex ^ this.id;
            return x;
        }
        public override string ToString()
        {
            return name+" "+surname+ " " + lastname;
        }
    }
}
