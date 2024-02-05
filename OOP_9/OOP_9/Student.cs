using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_9
{
    
    internal class Student
    {
        public int Id { get; }
        public string Name { get;}
        public int Group { get; }
        public Student() { }
        public Student(int id,string name,int group)
        {
            Id = id;
            Name = name;
            Group = group;
        }
    }
}
