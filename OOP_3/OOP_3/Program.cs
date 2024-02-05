using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Set A = new Set("hello","world","!","green");
            A.Add("car");
            A.Print();
            Console.WriteLine(A.Size());
            Console.WriteLine(A.Contains("hello"));
            A.Remove("world");
            Console.WriteLine(A.Size());
            Console.WriteLine( A.Shorter());
            Set B = new Set("car");
            B += "green";
            B-="car";
            B.Print();
            Console.WriteLine(B != A);
            Console.WriteLine(B < A);
            Set C = A % B;
            Console.WriteLine(C[0]);
            C[0] = "black";
            C.Print();

            C.Prod = new Production(444, "ooo");
            Set.Developer dev =new Set.Developer(C,"Petro",15,"front");

            Console.WriteLine(StaticOperation.getBackLength(A));

            C.RemoveSpace();
        }
    }
}
