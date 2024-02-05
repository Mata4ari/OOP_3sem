using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace OOP_13
{
    public class BinarySerializer : ISerializer
    {
        public void Serialize<T>(T obj, string fileName)
        {
            BinaryFormatter formatter = new BinaryFormatter();
            using (FileStream fileStream = new FileStream(fileName, FileMode.Create))
            {
                formatter.Serialize(fileStream, obj);
            }
        }
        public T Deserialize<T>(string fileName)
        {
            BinaryFormatter formatter = new BinaryFormatter();
            using (FileStream fileStream = new FileStream(fileName, FileMode.Open))
            {
                return (T)formatter.Deserialize(fileStream);
            }
        }
    }
}
