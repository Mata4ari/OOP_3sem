using System;

namespace OOP_4
{
    class Printer:Product,ITechnique
    {
        public override int Id { get; set; }
        virtual public void IAmPrinting(ITechnique obj)
        {
            Console.WriteLine( obj.ToString());
        }

        public Chip chip;
        public Printer()
        {
            device = Devices.Printer;
            chip = new Chip(125534);
        }
        public Printer(int cost, int date)
        {
            Cost = cost;
            Explotation = date;
            device = Devices.Printer;
        }
        public void Start() { Console.WriteLine("Printer printing..."); }
        public void Stop() { Console.WriteLine("Printer stop printing"); }
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
            Printer clone = new Printer();
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
