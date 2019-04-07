using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MilitaryUnit.Soldiers;

namespace MilitaryUnit.Vehicles
{
    class Helicopter : Vehicle
    {
        public Helicopter(string name, int capacity) : base(name, capacity)
        {
            this.name = name;
            maxPassenger = capacity;
        }

        public override void LoadTroops(Personnel soldier)
        {
            if (manifest.Count <maxPassenger)
            {
                manifest.Add(soldier);
                Console.WriteLine($"{soldier.name} is on the {name}");
                var currentLocation = soldier.GetPosition();
                newLocation.Item1 = currentLocation.Item1;
                newLocation.Item2 = currentLocation.Item2;
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
            newLocation.Item1 += 150 * x;
            newLocation.Item2 += 150 * y;
            Console.WriteLine($"Simulating Travel. Arrived: {newLocation}");
            soldier.ResetPositionVehicleDismount(newLocation.Item1, newLocation.Item2);
        }


        public void SkyDive(Personnel soldier)
        {
            if (soldier is Ranger || soldier is _82ndParatrooper)
            {
                Console.WriteLine($"Simulating {soldier.name} jumping out of {name}");
            }
            else
            {
                Console.WriteLine($"{soldier.name} is not trained for this type of operation.");
            }
        }
    }
}
