using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilitaryUnit.Soldiers
{
    public class _82ndParatrooper:Personnel,IAirborne
    {
        public _82ndParatrooper(string name) : base(name)
        {
            x = 0;
            y = 0;
            hp = 100;
            base.name = name;
            
        }
        public void AirborneOperation()
        {
            if (hp > 20)
            {
                hp -= 20;
                Console.WriteLine($"{name}: Hurry up and wait! \n9 hours later... HP: {hp}");
            }
            else
            {
                Console.WriteLine($"{name}: Still recovering from the last jump...");
            }
        }

        public override void Move(int x, int y)
        {
            base.x += 2 * x;
            base.y += 2 * y;
        }

        public override void EatMRE()
        {
            hp += 10;
            Console.WriteLine($"{name}: Not again. \nHP +10\nHP: {hp}");
        }



    }
}
