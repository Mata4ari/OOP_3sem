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
            return "Тип " + obj.GetType().Name + " " + obj.Cost + " " + obj.Name;
        }
    }
}
