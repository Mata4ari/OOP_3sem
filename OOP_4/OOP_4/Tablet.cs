using System;

namespace OOP_4
{
    class Tablet : Product,ITechnique
    {
        public Chip chip;
        public override int Id { get; set; }
        public Tablet()
        {
            chip = new Chip(7734);
        }
        public Tablet(int id)
        {
            chip = new Chip(7734);
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
            return "Тип " + obj.GetType().Name +" "+ obj.Cost + " " + obj.Name;
        }
    }
}
