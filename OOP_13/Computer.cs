using System;
using System.Xml.Serialization;

namespace OOP_13
{
    [Serializable]
    public class Computer : Product,ITechnique
    {
        public Computer() { }
        public Computer(int id,int cost,string name)
        {
            Name = name;
            Cost = cost;
            Id = id;
        }

        [NonSerialized][XmlIgnore]
        public int Id;
        public  void Start() { Console.WriteLine("Computer calculating..."); }
        public  void Stop() { Console.WriteLine("Computer stop calculating"); }
        public override void PrintCategory()
        {
            Console.WriteLine("Текущая категория Товары");
        }
        void ITechnique.PrintCategory()
        {
            Console.WriteLine("Текущая категория Техника");
        }
        public override string ToString()
        {
            Product obj = this;
            return "Тип " + obj.GetType().Name + " " + obj.Cost + " " + obj.Name+" "+this.Id;
        }
    }
}
