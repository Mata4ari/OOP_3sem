using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace OOP_8
{
    internal class StringOperations
    {
        public static string DeleteSymbol (string str,string ch)
        {
            Func<string, string> op;
            op=(c)=>str.Replace(c,"");
            return op(ch);
        }
        public static string insertFront( string str,string str2)
        {
            Func<string,string> op;
            op = (s) => str.Insert(0, s);
            return op(str2);
        }
        public static void ToUpperCase(ref string str)
        {
            Func<string,string> op;
            op=(s)=>s.ToUpper();
            str=op(str);
        }
        public static void ToLowerCase(ref string str)
        {
            Func<string,string,string> op;
            op = (s,a) => s.ToLower();
            str = op(str,str);
        }
        public static bool CheckLength(string str,int len)
        {
            Predicate<string> op;
            op = (s) => s.Length > len;
            return op(str);
        }

    }
}
