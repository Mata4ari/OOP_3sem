using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.IO;
using System.Reflection;

namespace OOP_11
{
    internal static class Reflector
    {
        public static string GetAssemblyName(Type type,string path)
        {
            File.AppendAllText(path, type.Assembly.FullName+"\n");
            return type.Assembly.FullName;
        }
        public static void GetConstructors(Type type,string path)
        {
            var bf = BindingFlags.Public|BindingFlags.Instance;
            var tt = type.GetConstructors(bf);
            foreach(var i in tt)
            {
                Console.WriteLine(i);
                File.AppendAllText(path,JsonConvert.SerializeObject( i) + "\n");
            }
        }
        public static IEnumerable<string> GetMethods(Type type,string path)
        {
            List<string> list = new List<string>();
            var bf = BindingFlags.Public|BindingFlags.Instance;
            var tt=type.GetMethods(bf);
            foreach (var i in tt)
            {
                list.Add(i.Name);
                Console.WriteLine(i);
                File.AppendAllText(path, JsonConvert.SerializeObject(i) + "\n");
            }
            return list;
        }
        public static IEnumerable<string> GetFields(Type type,string path)
        {
            List<string> list = new List<string>();
            foreach (var i in type.GetFields())
            {
                list.Add(i.Name);
                Console.WriteLine(i);
                File.AppendAllText(path, JsonConvert.SerializeObject(i) + "\n");
            }
            foreach(var i in type.GetProperties())
            {
                list.Add(i.Name);
                Console.WriteLine(i);
                File.AppendAllText(path, JsonConvert.SerializeObject(i) + "\n");
            }
            return list;
        }
        public static IEnumerable<string> GetInterfaces(Type type,string path)
        {
            List<string> list = new List<string>();
            TypeFilter myFilter = new TypeFilter(MyInterfaceFilter);
            String[] myInterfaceList = new string[2]
                {"System.Collections.IEnumerable",
                "System.Collections.ICollection"};

            
            foreach (var i in type.FindInterfaces(myFilter,myInterfaceList))
            {
                list.Add(i.Name);
                Console.WriteLine(i);
                File.AppendAllText(path, JsonConvert.SerializeObject(i) + "\n");
            }
            return list;
        }
        public static bool MyInterfaceFilter(Type typeObj, Object criteriaObj)
        {
            if (typeObj.ToString() == criteriaObj.ToString())
                return true;
            else
                return false;
        }

        public static void GetMethodByParm(Type type,object parm)
        {
            var methods = type.GetMethods();
            List<MethodInfo> result=new List<MethodInfo>();
            foreach(var i in methods)
            {
                var parms = i.GetParameters();
                
                foreach(var j in parms)
                {
                    if (j.ParameterType== parm.GetType())
                    {
                        result.Add(i);
                        continue;
                    }
                }
            }

            foreach(var i in result)
            {
                Console.WriteLine(i.Name);
            }

        }
        public static void Invoke(object obj,string methodName)
        {
            var method = obj.GetType().GetMethod(methodName);
            Console.WriteLine("\n"+method.Name);

            var parameters = method.GetParameters();
            var values = new object[parameters.Length];
            int i = 0;
            foreach (var parameterFromFile in File.ReadAllLines("parameters.txt"))
            {
                if (i < parameters.Length)
                {
                    values[i] = parameterFromFile;
                }
                else
                {
                    break;
                }
                i++;
            }
            method.Invoke(obj, values);
        }
        public static void InvokeRandom(object obj, string methodName)
        {
            var method = obj.GetType().GetMethod(methodName);
            var parameters = method.GetParameters();
            var values = new object[parameters.Length];

            char[] letters = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz".ToCharArray();
            Random rand = new Random();

            for (int i = 0; i < parameters.Length; i++)
            {
                string word = "";
                for (int j = 1; j <= 8; j++)
                {
                    int letter_num = rand.Next(0, letters.Length - 1);
                    word += letters[letter_num];
                }
                values[i]=word;
            }

            method.Invoke(obj, values);
        }
        public static T Create<T>(object[] parameters)
        {
            var type = typeof(T);
            var constructor = type.GetConstructor(parameters.Select(p => p.GetType()).ToArray());
            if (constructor == null)
            {
                return default(T);
            }
            else
            {
                return (T)constructor.Invoke(parameters);
            }
        }
    }
}
