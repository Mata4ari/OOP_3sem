using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_8
{
    public class Player
    {
        public int HP{get;set;}
        public Player()
        {
            HP = 100;
        }
        public Player(int val)
        {
            HP = val;
        }
        public virtual void GetHeal(int val,CalculateHeal calculateHeal)
        {
            HP += calculateHeal(val);
        }
        public virtual void GetDamage(int val,CalculateDamage calculateDamage)
        {
            HP-= calculateDamage(val);
        }
    }
}
