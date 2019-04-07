using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilitaryUnit
{

    public class Personnel
    {
        protected int x=10;
        protected int y=10;
        protected int hp=80;
        public string name { get; set; }

        public Personnel(string name)
        {
            this.name = name;
        }

        public virtual void Move(int x, int y)
        {
            this.x += x;
            this.y += y;
        }

        public virtual void EatMRE()
        {
            hp += 5;
            Console.WriteLine($"{name}: Yuck...\nHP + 5\nHP: {hp}");
        }

        public (int, int) GetPosition()
        {
            return (x, y);
        }

        public void PrintCurrentPosition()
        {
            Console.WriteLine($"{name}'s current location: {(x, y)}");
        }

        public void ResetPositionVehicleDismount(int a, int b)
        {
            x = a;
            y = b;
        }
        
        public int CheckHP() => hp;
        
    }
}
