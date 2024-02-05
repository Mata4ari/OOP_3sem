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
            return "Тип " + obj.GetType().Name + " " + obj.Cost + " " + obj.Name;
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
    }
}
