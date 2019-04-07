using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MilitaryUnit.Soldiers;
using MilitaryUnit.Vehicles;

namespace MilitaryUnit
{
    class Program
    {
        static void Main(string[] args)
        {
            Ranger powerRanger = new Ranger("Power Ranger");
            _82ndParatrooper troop = new _82ndParatrooper("Airborne Ace");
            Personnel wannabeRanger = new Personnel("GI Joe");
            List<Personnel> Soldiers = new List<Personnel> { powerRanger, troop, wannabeRanger };
            List<IAirborne> Paragliders = new List<IAirborne> { powerRanger, troop };

            SuperCoolMotorCycle superCycle = new SuperCoolMotorCycle("GhostRider",1);
            WheeledVehicle humvee = new WheeledVehicle("HMMWV", 5);
            Helicopter chinook = new Helicopter("CH-47", 8);

            DisplayColorComment("For each ranger, paratrooper, and Soldier, demonstrate eating a meal, traveling for an hour, and mounting/dismounting a vehicle.");
            Console.WriteLine();
            foreach (var solider in Soldiers)
            {
                solider.EatMRE();
                solider.PrintCurrentPosition();
                Console.WriteLine($"{solider.name} moved for an hour.");
                solider.Move(10,10);
                solider.PrintCurrentPosition();
                superCycle.LoadTroops(solider);
                superCycle.UnloadTroops(solider);
                humvee.LoadTroops(solider);
                Console.WriteLine();
            }

            var manifest = humvee.GetManifest();
            Console.Write($"List of passangers in {humvee.name}: ");

            foreach (var passenger in manifest)
            {
                Console.Write(passenger.name + " || ");
            }

            Console.WriteLine();
            DisplayColorComment("Soldier traveling in a vehicle");  // Would work better as a method.
            wannabeRanger.PrintCurrentPosition();
            humvee.LoadTroops(wannabeRanger);
            humvee.Move(wannabeRanger, 5, 10);
            wannabeRanger.PrintCurrentPosition();

            DisplayColorComment("Only rangers and paratroopers can do airborne operation.");
            DisplayColorComment("Paratroopers get bored and lose HP during the preparation.");
            foreach (var paraglider in Paragliders)
            {
                paraglider.AirborneOperation();
            }

            DisplayColorComment("Only rangers and paratroopers can a ride super cool motorcycle.");
            foreach (var soldier in Soldiers)
            {
                Console.Write(soldier.name);
                superCycle.Wheelie(soldier);
            }

            DisplayColorComment("Soldiers can travel in a helicopter. Only Airborne qualified personnel can perform a jump");
            foreach (var soldier in Soldiers) 
            {
                chinook.LoadTroops(soldier);
                chinook.SkyDive(soldier);
            }
                                                  
        }

        private static void DisplayColorComment(string comment)
        {
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(comment);
            Console.ResetColor();
        }
    }
}
