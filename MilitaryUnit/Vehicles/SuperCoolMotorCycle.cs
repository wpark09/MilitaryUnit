using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MilitaryUnit.Soldiers;

namespace MilitaryUnit.Vehicles
{
    public class SuperCoolMotorCycle: WheeledVehicle
    {
        public SuperCoolMotorCycle(string name, int capacity): base(name, capacity)
        {
            base.name = name;
            maxPassenger = capacity;
        }

        public override void LoadTroops(Personnel soldier)
        {
            if (manifest.Count == 0 && soldier is IAirborne)
            {
                manifest.Add(soldier);
                Console.WriteLine($"{soldier.name} is on the {name}");
                var currentLocation = soldier.GetPosition();
                newLocation.Item1 = currentLocation.Item1;
                newLocation.Item2 = currentLocation.Item2;
            }
            else
            {
                Console.WriteLine($"No seats available for {soldier.name}.");
            }
        }


        public override void UnloadTroops(Personnel soldier)
        {
            {
                manifest.Remove(soldier);
                soldier.ResetPositionVehicleDismount(newLocation.Item1, newLocation.Item2);
            }
        }

        public override void Move(Personnel soldier, int x, int y)
        {
            newLocation = soldier.GetPosition();
            newLocation.Item1 += 50 * x;
            newLocation.Item2 += 50 * y;
            Console.WriteLine($"Simulating Travel. Arrived: {newLocation}");
            soldier.ResetPositionVehicleDismount(newLocation.Item1, newLocation.Item2);
        }


        public void Wheelie(Personnel soldier)
        {
            if (soldier is Ranger)
            {
                Console.WriteLine("Simulating a ranger doing a power wheelie");
            }
            else if(soldier is _82ndParatrooper)
            {
                Console.WriteLine("Simulating a trooper attempting a wheelie");
            }
            else
            {
                Console.WriteLine("Can't touch this. You are NOT cool enough.");
            }
        }
    }
}
