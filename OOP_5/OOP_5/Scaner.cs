using System;

namespace OOP_4
{
    class Scaner : Product,ITechnique
    {
        public Chip chip;
        public override int Id { get; set; }
        public Scaner()
        {
            chip = new Chip(125534);
        }
        public Scaner(int cost, int date)
        {
            Cost = cost;
            Explotation = date;
        }
        public  void Start() { Console.WriteLine("Scaner start scaning..."); }
        public  void Stop() { Console.WriteLine("Scaner stop scaning"); }
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
            Scaner clone = new Scaner();
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
