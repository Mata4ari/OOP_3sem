using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace OOP_7
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

    public class Set<T>:IStr<T> where T : new()
    {
        public List<T> list;
        public int size;
        Production prod;
        public static string name;

        public Production Prod { get => prod; set => prod = value; }

        public class Developer
        {
            string name;
            int id;
            string dep;
            
            public Developer(Set<T> parent,string name, int id,string dep)
            {
                this.name = name;
                this.id = id;
                this.dep = dep;
            }
        }
        public Set()
        {
            list= new List<T>();
            size = 0;
        }
        public Set(params T[] nums)
        {
            list = new List<T>();
            foreach (T i in nums)
            {
                if (!list.Contains(i))
                {
                    list.Add(i);
                    size++;
                }
            }
        }
        public void Add(T i)
        {
            if (!list.Contains(i))
            {
                list.Add(i);
                size++;
            }
        }
        public int Size() { return size; }
        public void Remove(T i)
        {
            list.Remove(i);
            size--;
        }
        public bool Contains(T i)
        {
            return list.Contains(i);
        }
        public void Print()
        {
            foreach(T i in list)
            {
                Console.Write(i+" ");
            }
            Console.WriteLine();
        }
        public void Order()
        {
            list.Sort();
        }
        public T Longer()
        {
            list.Sort();
            return list[list.Count-1];
        }
        public T Shorter()
        {
            list.Sort();
            return (list[0]);
        }
        public static Set<T> operator -( Set<T> obj,T str)
        {
            obj.list.Remove(str);
            obj.size--;
            return obj;
        }
        public static Set<T> operator +( Set<T> obj,T str)
        {
            obj.list.Add(str);
            obj.size++;
            return obj;
        }
        public static bool operator !=(Set<T> A,Set<T> B)
        {
            if(A.Size()!= B.Size())
                return true;
            foreach(T i in A.list)
            {
                if(!B.list.Contains(i))
                    return true;
            }
            return false;
        }
        public static bool operator ==(Set<T> A,Set<T> B)
        {
            return !(A != B);
        }
        public static bool operator >(Set<T> A,Set<T> B)
        {
            if (A.Size() < B.Size())
                return false;
            foreach(T i in B.list)
            {
                if (!A.list.Contains(i))
                    return false;
            }
            return true;
        }
        public static bool operator <(Set<T> A,Set<T> B)
        {
            if (B.Size() < A.Size())
                return false;
            foreach (T i in A.list)
            {
                if (!B.list.Contains(i))
                    return false;
            }
            return true;
        }
        public static Set<T> operator %(Set<T> A,Set<T> B)
        {
            Set<T> C = new Set<T>();
            foreach(T i in A.list)
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
            return GetHashCode();
        }
        public override string ToString()
        {
            string str="";
            foreach(var i in list)
            {
                str += i + " ";
            }
            str += "\n" + size;
            return str;
        }

        public T this[int index]
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
                    return default(T);
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
