using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace OOP_3
{
    public class Production
    {
        int id;
        string name;
        public Production(int id, string name)
        {
            this.id = id;
            this.name = name;
        }
    }

    internal class Set
    {
        List<string> list;
        int size;
        Production prod;

        public Production Prod { get => prod; set => prod = value; }

        public class Developer
        {
            string name;
            int id;
            string dep;
            
            public Developer(Set parent,string name, int id,string dep)
            {
                this.name = name;
                this.id = id;
                this.dep = dep;
            }
        }
        public Set()
        {
            list= new List<string>();
            size = 0;
        }
        public Set(params string[] nums)
        {
            this.list = new List<string>();
            foreach (string i in nums)
            {
                if (!list.Contains(i))
                {
                    list.Add(i);
                    size++;
                }
            }
        }
        public void Add(string i)
        {
            if (!list.Contains(i))
            {
                list.Add(i);
                size++;
            }
        }
        public int Size() { return size; }
        public void Remove(string i)
        {
            list.Remove(i);
            size--;
        }
        public bool Contains(string i)
        {
            return list.Contains(i);
        }
        public void Print()
        {
            foreach(string i in list)
            {
                Console.Write(i+" ");
            }
            Console.WriteLine();
        }
        public void Order()
        {
            list.Sort();
        }
        public string Longer()
        {
            list.Sort();
            return list[list.Count-1];
        }
        public string Shorter()
        {
            list.Sort();
            return (list[0]);
        }
        public static Set operator -( Set obj,string str)
        {
            obj.list.Remove(str);
            obj.size--;
            return obj;
        }
        public static Set operator +( Set obj,string str)
        {
            obj.list.Add(str);
            obj.size++;
            return obj;
        }
        public static bool operator !=(Set A,Set B)
        {
            if(A.Size()!= B.Size())
                return true;
            foreach(string i in A.list)
            {
                if(!B.list.Contains(i))
                    return true;
            }
            return false;
        }
        public static bool operator ==(Set A,Set B)
        {
            return !(A != B);
        }
        public static bool operator >(Set A,Set B)
        {
            if (A.Size() < B.Size())
                return false;
            foreach(string i in B.list)
            {
                if (!A.list.Contains(i))
                    return false;
            }
            return true;
        }
        public static bool operator <(Set A,Set B)
        {
            if (B.Size() < A.Size())
                return false;
            foreach (string i in A.list)
            {
                if (!B.list.Contains(i))
                    return false;
            }
            return true;
        }
        public static Set operator %(Set A,Set B)
        {
            Set C = new Set();
            foreach(string i in A.list)
            {
                if(B.list.Contains(i))
                    C.Add(i);
            }
            return C;
        }

        public override bool Equals(object obj1)
        {
            if (this.GetType() != obj1.GetType())
                return false;
            if (obj1 == null) return false;
            return true;
        }
        public override int GetHashCode()
        {
            int x = list[0][0];
            return x;
        }
        public string this[int index]
        {
            get
            {
                if (index >= 0 && index < size)
                {
                    return list[index];
                }
                else
                { 
                    Console.WriteLine("Индекс находится за пределами допустимого диапазона.");
                    return "";
                }
            }
            set
            {
                if (index >= 0 && index < size)
                {
                list[index] = value;
                }
                else
                {
                 Console.WriteLine("Индекс находится за пределами допустимого диапазона.");
                }
            }
        }
    }
}
