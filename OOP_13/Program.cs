using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.IO;
using System.Xml.XPath;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;

namespace OOP_13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Computer computer = new Computer(333, 232, "Le-231");
            var xmlserializer = new XMLSerializer();
            var binserializer = new BinarySerializer();
            var soapserializer= new SOAPSerializer();
            var jsonserializer=new JSONSerializer();

            xmlserializer.Serialize(computer, "data.xml");
            binserializer.Serialize(computer, "data.bin");
            soapserializer.Serialize(computer, "data.soap");
            jsonserializer.Serialize(computer, "data.json");

            var comp1 = xmlserializer.Deserialize<Computer>("data.xml");
            Console.WriteLine(comp1.ToString());
            var comp2 = binserializer.Deserialize<Computer>("data.bin");
            Console.WriteLine(comp2.ToString());
            var comp3 = soapserializer.Deserialize<Computer>("data.soap");
            Console.WriteLine(comp3.ToString());
            var comp4 = jsonserializer.Deserialize<Computer>("data.json");
            Console.WriteLine(comp4.ToString()+"\n");

            var computers = new List<Computer> {new Computer(174,111,"asus"), new Computer(229,252,"huawei"), new Computer(963,555,"lenovo")};
            jsonserializer.Serialize(computers, "computers.json");
            var list = jsonserializer.Deserialize<List<Computer>>("computers.json");
            foreach(var item in list)
            {
                Console.WriteLine(item.ToString());
            }
            Console.WriteLine();
            binserializer.Serialize(computers, "computers.bin");
            var list1 = binserializer.Deserialize<List<Computer>>("computers.bin");
            foreach (var item in list1)
            {
                Console.WriteLine(item.ToString());
            }
            Console.WriteLine();
            soapserializer.Serialize(computers, "computers.soap");
            var list2 = soapserializer.Deserialize<List<Computer>>("computers.soap");
            foreach (var item in list2)
            {
                Console.WriteLine(item.ToString());
            }
            Console.WriteLine();
            xmlserializer.Serialize(computers, "computers.xml");
            var list3 = xmlserializer.Deserialize<List<Computer>>("computers.xml");
            foreach (var item in list3)
            {
                Console.WriteLine(item.ToString());
            }
            Console.WriteLine();


            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.LoadXml(File.ReadAllText("data.xml"));
            XPathNavigator navigator = xmlDoc.CreateNavigator();
            var node = navigator.SelectSingleNode("/Computer/Cost");
            Console.WriteLine(node.Value);
            var node1 = navigator.SelectSingleNode("/Computer/Name");
            Console.WriteLine(node1.Value);



            JObject json = JObject.Parse(File.ReadAllText("data.json"));
            var result = json.SelectToken("Cost");
            Console.WriteLine(result);
            var result1 = json.SelectToken("Name");
            Console.WriteLine(result1);
        }
    }
}
