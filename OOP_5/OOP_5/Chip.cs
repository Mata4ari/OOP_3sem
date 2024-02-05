using System;

namespace OOP_4
{
    sealed class Chip
    {
        public Chip(int id)
        {
            this.id = id;
        }
        int id;
        public void getChipId() { Console.WriteLine("Chip id "+id); }
    }
}
