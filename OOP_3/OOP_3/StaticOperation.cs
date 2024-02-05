using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_3
{
    static class StaticOperation
    {
        static public int getSize(Set obj)
        {
            return obj.Size();
        }
        static public int getFrontLength(Set obj)
        {
            return obj.Shorter().Length;
        }
        static public int getBackLength (Set obj)
        {
            return obj.Longer().Length;
        }
        public static void RemoveSpace(this Set obj)
        {
            while(obj.Contains(""))
            {
                obj.Remove("");
            }
        }
        public static int WordCount(this string str)
        {
            return str.Split(new char[] { ' ', '.', '?',',','!' },StringSplitOptions.RemoveEmptyEntries).Length;
        }
    }
}
