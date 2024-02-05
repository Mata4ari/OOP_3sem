using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_9
{
    internal class MyList<T>
    {
        ArrayList arr;
        List<T> list;
        public MyList()
        {
            list = new List<T>();
        }
        public MyList(MyQueue<T> q)
        {
            list = new List<T>();
            foreach (var item in q)
            {
                list.Add(item);
            }
        }
        public void Add(T item)
        {
            list.Add(item);
        }
        public void Print()
        {
            foreach (var item in list)
            {
                Console.Write(item+" ");
            }
            Console.WriteLine();
        }
        public bool Contains(T item) 
        {
            return list.Contains(item);
        }
    }
}
