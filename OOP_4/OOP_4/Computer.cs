using System;

namespace OOP_4
{
    class Computer : Product,ITechnique
    {
        public Chip chip;
        public override int Id { get; set; }
        public Computer()
        {
            chip = new Chip(1134);
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
            return "Тип " + obj.GetType().Name + " " + obj.Cost + " " + obj.Name;
        }
    }
}
