using Microsoft.VisualStudio.TestTools.UnitTesting;
using MilitaryUnit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MilitaryUnit.Soldiers;
using MilitaryUnit.Vehicles;

namespace MilitaryUnit.Tests
{
    [TestClass()]
    public class VehicleTests
    {
        Ranger rangerUnderTest;
        Personnel soldierUnderTest;
        WheeledVehicle vehicleUnderTest;

        [TestInitialize()]
        public void StartUp()

        {
            rangerUnderTest = new Ranger("Ranger under test");
            soldierUnderTest = new Personnel("Soldier under test");
            vehicleUnderTest = new WheeledVehicle ("wheeled vehicle under test",8);
        }

        [TestMethod()]
        public void MoveTest()
        {
            vehicleUnderTest.LoadTroops(rangerUnderTest);
            vehicleUnderTest.LoadTroops(soldierUnderTest);

            Assert.AreEqual(6,vehicleUnderTest.ReturnCapacity());
            Assert.AreEqual(2, vehicleUnderTest.GetManifest().Count);
        }
    }
}


//SuperCoolMotorCycle motorCycleUnderTest;
//motorCycleUnderTest = new SuperCoolMotorCycle("Ghost rider under test", 1);
