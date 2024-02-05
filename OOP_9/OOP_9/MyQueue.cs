using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_9
{
    internal class MyQueue<T> : IEnumerable<T>
    {
        Queue<T> q;
       public MyQueue() { q = new Queue<T>(); }
        public IEnumerator<T> GetEnumerator()
        {
            return q.GetEnumerator();
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return q.GetEnumerator();
        }

        public void Add(T item) 
        {
            q.Enqueue(item);
        }
        public T Delete() 
        {
            return q.Dequeue();
        }
        public bool Cheack(T item)
        {
            return q.Contains(item);
        }
        public void print()
        {
            foreach (T item in q) 
            {
                Console.Write(item+" ");
            }
            Console.WriteLine();
        }
        public void DeleteN(int n) 
        {
            for(int i=0;i<n;i++)
            {
                q.Dequeue();
            }
        }
        public void CopyToList(List<T> list)
        {
            foreach(T item in q)
            {
                list.Add(item);
            }
        }
    }
}
