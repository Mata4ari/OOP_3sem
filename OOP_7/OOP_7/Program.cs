using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.IO;

namespace OOP_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Set<int> set1 = new Set<int>(4,3,2,1);
                Console.WriteLine(set1.Contains(3));
                Set<double> set2 = new Set<double>(3.77, 1, 3.3, 1, 6.12);
                Console.WriteLine(set2.Contains(6.12));
                Set<PrintMachine> set3 = new Set<PrintMachine>();
                PrintMachine pr = new PrintMachine("LE-11",111);
                set3.Add(pr);
                Console.WriteLine( set3.Contains(pr));
                Set<int>.name = "ints";
                Set<double>.name = "doubles";

                string jsonOut = JsonConvert.SerializeObject(set2);
                string filePath = "A.json";
                File.WriteAllText(filePath, jsonOut);

            }
            catch(DirectoryNotFoundException e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine(e.ToString());
                Console.WriteLine(e.StackTrace);
            }
            catch(Exception e) 
            {
                Console.WriteLine(e.Message);
                Console.WriteLine(e.Source);
            }
            finally
            {
                string filePath = "A.json";
                string jsonIn = File.ReadAllText(filePath);
                Console.WriteLine(jsonIn);
                Set<double> setIn = JsonConvert.DeserializeObject<Set<double>>(jsonIn);
                Console.WriteLine(setIn.ToString());
            }
        }
    }
}
