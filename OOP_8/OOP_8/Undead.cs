using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_8
{
    internal class Undead:Player
    {
       public Undead() : base() { }
       public Undead(int val) : base(val) { }
        public override void GetHeal(int val, CalculateHeal calculateHeal)
        {
            HP -= calculateHeal(val);
        }
        public override void GetDamage(int val, CalculateDamage calculateDamage)
        {
            
        }
    }
}
