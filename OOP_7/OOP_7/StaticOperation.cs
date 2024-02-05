using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_7
{
    static class StaticOperation
    {
        static public int getSize<T>(Set<T> obj) where T : new()
        {
            return obj.Size();
        }
        static public T getFrontL<T>(Set<T> obj) where T : new()
        {
            return obj.Shorter();
        }
        static public T getBackLength<T>(Set<T> obj) where T : new()
        {
            return obj.Longer();
        }
        public static void RemoveSpace<T>(this Set<T> obj) where T : new()
        {
            while(obj.Contains(default(T)))
            {
                obj.Remove(default(T));
            }
        }
        public static int WordCount(this string str)
        {
            return str.Split(new char[] { ' ', '.', '?',',','!' },StringSplitOptions.RemoveEmptyEntries).Length;
        }
    }
}
