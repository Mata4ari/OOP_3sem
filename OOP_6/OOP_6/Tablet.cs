using System;

namespace OOP_6
{
    class Tablet : Product,ITechnique
    {
        public Chip chip;
        public override int Id { get; set; }
        public Tablet()
        {
            chip = new Chip(7734);
            device = Devices.Tablet;
        }
        public Tablet(int cost, int date)
        {
            if (date > 15)
            {
                throw new UncorrectData(date);
            }
            Cost = cost;
            Explotation = date;
            device = Devices.Tablet;
        }
        public  void Start() { Console.WriteLine("Tablet play video..."); }
        public  void Stop() { Console.WriteLine("Tablet stop working"); }
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
            return "Тип " + obj.GetType().Name + " Cost:" + obj.Cost + " " + obj.Name + " Explotation:" + obj.Explotation;
        }
        public override object Clone()
        {
            Tablet clone = new Tablet();
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
