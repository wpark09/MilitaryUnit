using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MilitaryUnit.Soldiers;

namespace MilitaryUnit
{
    public class Vehicle
    {
        public int maxPassenger;
        public string name;
        public (int,int) newLocation;
        public List<Personnel> manifest = new List<Personnel>();


        public Vehicle(string name, int capacity)
        {
            this.name = name;
            maxPassenger = capacity;
        }

        public virtual void LoadTroops(Personnel soldier)
        {
            if (maxPassenger == 0)
            {
                Console.WriteLine("No seats available.");
            }

            else
            {
                maxPassenger -= 1;
                var currentLocation = soldier.GetPosition();
                newLocation.Item1 = currentLocation.Item1;
                newLocation.Item2 = currentLocation.Item2;
                manifest.Add(soldier);
                Console.WriteLine($"{soldier.name} is on the {name}");
            }
        }

        public virtual void UnloadTroops(Personnel soldier)
        {
            {
                maxPassenger += 1;
                manifest.Remove(soldier);
                soldier.ResetPositionVehicleDismount(newLocation.Item1, newLocation.Item2);
            }
        }

        public virtual void Move(Personnel soldier, int x, int y)
        {
            newLocation = soldier.GetPosition();
            newLocation.Item1 += 10 * x;
            newLocation.Item2 += 10 * y;
            Console.WriteLine($"Simulating Travel. Arrived: {newLocation}");
            soldier.ResetPositionVehicleDismount(newLocation.Item1, newLocation.Item2);
        }

        public virtual int ReturnCapacity() => maxPassenger;
        public virtual List<Personnel> GetManifest() => manifest;

    }
}
