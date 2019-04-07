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
    public class _82ndParatrooperTests
    {
        _82ndParatrooper oot;
        [TestInitialize()]
        public void StartUp()
        {
            oot = new _82ndParatrooper("Trooper under test");
        }

        [TestMethod()]
        public void MoveTest()
        {
            oot.Move(1, 1);
            Assert.AreEqual((2, 2), oot.GetPosition());

            oot.Move(4, 4);
            Assert.AreEqual((8, 8), oot.GetPosition());
        }

        [TestMethod()]
        public void HPTest()
        {
            //initial HP = 100, each MRE hp+=10
            oot.EatMRE();
            Assert.AreEqual(110, oot.CheckHP());
        }

        [TestMethod()]
        public void AirborneOperationTest()
        {
            //Paratrooper hp-=20 on each jump 
            oot.AirborneOperation();
            Assert.AreEqual(80, oot.CheckHP());
        }
    }
}