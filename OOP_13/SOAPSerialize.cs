using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Soap;

namespace OOP_13
{
    public class SOAPSerializer : ISerializer
    {
        public void Serialize<T>(T obj, string fileName)
        {
            using (FileStream fileStream = new FileStream(fileName, FileMode.Create))
            {
                var serializer = new SoapFormatter();
                serializer.Serialize(fileStream, obj);
            }
        }

        public T Deserialize<T>(string fileName)
        {
            using (FileStream fileStream = new FileStream(fileName, FileMode.Open))
            {
                var serializer = new SoapFormatter();
                return (T)serializer.Deserialize(fileStream);
            }
        }
    }
}
