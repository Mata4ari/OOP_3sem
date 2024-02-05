using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.IO;

namespace OOP_13
{
    public class JSONSerializer : ISerializer
    {
        public void Serialize<T>(T obj, string fileName)
        {
            string json = JsonSerializer.Serialize(obj);
            File.WriteAllText(fileName, json);
        }

        public T Deserialize<T>(string fileName)
        {
            string json = File.ReadAllText(fileName);
            return JsonSerializer.Deserialize<T>(json);
        }
    }
}
