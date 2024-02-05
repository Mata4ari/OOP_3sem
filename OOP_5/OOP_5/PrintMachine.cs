using System;

namespace OOP_4
{
    class PrintMachine :Product,ITechnique
    {
       public override int Id { get; set; }

        public Chip chip;
        public PrintMachine()
        { 
            chip = new Chip(1234);
            device = Devices.PrintMachine;
        }
        public PrintMachine(int cost, int date)
        {
            Cost = cost;
            Explotation = date;
            device = Devices.PrintMachine;
        }
      public  void  Start() { Console.WriteLine("Print machine start working"); }
      public  void Stop() { Console.WriteLine("Print machine stop working"); }
        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }
            if (this == obj)
                return true;
            return false;
        }
        public override string ToString()
        {
            Product obj = this;
            return "Тип " + obj.GetType().Name + " Cost:" + obj.Cost + " " + obj.Name + " Explotation:" + obj.Explotation;
        }
        public override int GetHashCode()
        {
            int x=chip.GetHashCode();
            return x;
        }
        public override void PrintCategory()
        {
            Console.WriteLine("Текущая категория Товары");
        }
         void ITechnique.PrintCategory()
        {
            Console.WriteLine("Текущая категория Техника");
        }

        public override object Clone()
        {
            PrintMachine clone = new PrintMachine();
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
