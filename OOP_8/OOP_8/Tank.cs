using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_8
{
    internal class Tank:Player
    {
        public Tank() : base() { }
        public Tank(int val) : base(val) { }

        public override void GetHeal(int val, CalculateHeal calculateHeal)
        {
            
        }
        public override void GetDamage(int val, CalculateDamage calculateDamage)
        {
            base.GetDamage(val, calculateDamage);
        }
    }
}
