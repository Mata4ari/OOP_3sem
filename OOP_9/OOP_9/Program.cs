using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var q = new MyQueue<int>();
                q.Add(1);
                q.Add(2);
                q.Add(27);
                q.Add(32);
                q.Add(3);
                q.Add(555);
                q.Add(748);
                Console.WriteLine(q.Cheack(2));
                q.print();
                q.Delete();
                q.print();
                q.DeleteN(2);
                q.print();

                var list = new MyList<int>(q);
                list.Print();
                Console.WriteLine(list.Contains(555));


                var students = new ObservableCollection<Student>();
                students.CollectionChanged += ObservCollectioncs.StudentCollectionChanged;
                students.Add(new Student(32432, "Artem", 6));
                students.Add(new Student(11111, "Nikita", 4));
                students.Remove(students[0]);
            }
            catch(Exception e) 
            {
                Console.WriteLine(e.Message);
                Console.WriteLine(e.Source);
            }
        }
    }
}
