using System;

namespace OOP_4
{
    class Computer : Product,ITechnique
    {
        public Chip chip;
        public override int Id { get; set; }
        public Computer()
        {
            device = Devices.Computer;
            chip = new Chip(1134);
        }
        public Computer(int cost,int date)
        {
            device = Devices.Computer;
            Cost = cost;
            Explotation = date;
        }
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
            return "Тип " + obj.GetType().Name + " Cost:" + obj.Cost + " " + obj.Name+" Explotation:"+obj.Explotation;
        }

        public override object Clone()
        {
            Computer clone =new Computer();
            clone.device = device;
            clone.chip = chip;
            clone.Explotation = Explotation;
            clone.Name = Name;
            clone.Id = Id;
            clone.Cost = Cost;
            return clone;
        }
    }
}
