using Microsoft.VisualStudio.TestTools.UnitTesting;
using MilitaryUnit.Soldiers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilitaryUnit.Soldiers.Tests
{
    [TestClass()]
    public class RangerTests
    {
        Ranger oot;

        [TestInitialize()]
        public void StartUp()

        {
            oot = new Ranger("Ranger under test");
        }

        [TestMethod()]
        public void MoveTest()
        {
            oot.Move(1, 1);
            Assert.AreEqual((3, 3), oot.GetPosition());

            oot.Move(4, 4);
            Assert.AreEqual((12, 12), oot.GetPosition());
        }

        [TestMethod()]
        public void HPTest()
        {
            //initial HP = 150, each MRE hp+=15
            oot.EatMRE();
            Assert.AreEqual(165, oot.CheckHP());
        }       
    }
}