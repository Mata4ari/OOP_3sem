using System;

namespace OOP_6
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
