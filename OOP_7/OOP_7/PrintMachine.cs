using System;

namespace OOP_7
{
    class PrintMachine :Product,ITechnique
    {
       public override int Id { get; set; }

        public PrintMachine(string name,int cost)
        {
            Name = name;
            Cost = cost;
        }
        public PrintMachine()
        { 
            
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
            return GetHashCode();
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
