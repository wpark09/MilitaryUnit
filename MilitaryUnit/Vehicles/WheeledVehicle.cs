using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MilitaryUnit.Soldiers;

namespace MilitaryUnit.Vehicles
{
    public class WheeledVehicle : Vehicle
    {
        public WheeledVehicle(string name, int capacity) : base(name, capacity)
        {
            this.name = name;
            base.maxPassenger = capacity;
        }

        public override void LoadTroops(Personnel soldier)
        {
            if (manifest.Count >= maxPassenger)
            {
                Console.WriteLine("No seats available.");
            }

            else
            {
                Console.WriteLine($"{soldier.name} is on the {name}");
                var currentLocation = soldier.GetPosition();
                newLocation.Item1 = currentLocation.Item1;
                newLocation.Item2 = currentLocation.Item2;
                manifest.Add(soldier);
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
            newLocation.Item1 += 10 * x;
            newLocation.Item2 += 10 * y;
            Console.WriteLine($"Simulating Travel. Arrived: {newLocation}");
            soldier.ResetPositionVehicleDismount(newLocation.Item1, newLocation.Item2);
        }

    }
}
