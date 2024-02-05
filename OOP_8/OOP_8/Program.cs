using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_8
{

    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Player player1 = new Player();
                Player tank = new Tank(1000);
                Player undead = new Undead(300);
                Player player2 = new Player();
                Game game = new Game();
                game.Heal += player1.GetHeal;
                game.Heal += tank.GetHeal;
                game.Heal += undead.GetHeal;
                game.Attack += player1.GetDamage;
                game.Attack += tank.GetDamage;
                game.Attack += undead.GetDamage;
                game.Attack += player2.GetDamage;
                game.GiveHP(50, (val) => val * 2);
                game.GiveDamage(50, (val) => val / 2);
                Console.WriteLine(player1.HP);
                Console.WriteLine(tank.HP);
                Console.WriteLine(undead.HP+"\n");

                string str = "Hello world!";
                StringOperations.ToUpperCase(ref str);
                Console.WriteLine(str);
                StringOperations.ToLowerCase(ref str);
                Console.WriteLine(str);
                str = StringOperations.DeleteSymbol(str, "!");
                Console.WriteLine(str);
                str = StringOperations.insertFront(str, "!");
                Console.WriteLine(str);
                Console.WriteLine(StringOperations.CheckLength(str, 5));
            }
            catch (Exception ex) { Console.WriteLine(ex.Message); }
        }
    }
}
