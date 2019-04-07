using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilitaryUnit.Soldiers
{
    public class Ranger : Personnel, IAirborne
    {
 
        public Ranger(string name) :base (name)
        {
            x = 5;
            y = 0;
            hp = 150;
            base.name = name;
        }

        public void AirborneOperation()
        {
            Console.WriteLine($"{name}: Another day in a paradise. Yoo hoo! HP: {hp}");
        }

        public override void Move(int x, int y)
        {
            base.x += 3 * x;
            base.y += 3 * y;
          
        }

        public override void EatMRE()
        {
            hp += 15;
            Console.WriteLine($"{name}: This tastes AWESOME. NUM NUM RANGER! \nHP +15\nHP: {hp}");
        }


    }
}
