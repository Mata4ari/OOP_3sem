using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_8
{
    public delegate void Heal(int val,CalculateHeal calculateHeal);
    public delegate void Attack(int val,CalculateDamage calculateDamage);
    public delegate int CalculateHeal(int val);
    public delegate int CalculateDamage(int val);
    public class Game
    {
        public event Heal Heal;
        public event Attack Attack;
        public void GiveDamage(int val, CalculateDamage calculateDamage)
        {
            
            if (Attack != null) { Attack(val, calculateDamage); }
            else 
            {
                throw new Exception("На событие не подписан ни один объект");
            }
        }
        public void GiveHP(int val,CalculateHeal calculateHeal)
        {
             Heal.Invoke(val,calculateHeal);
            
        }

    }
}
