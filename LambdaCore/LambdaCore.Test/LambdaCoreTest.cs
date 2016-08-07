using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LambdaCore.Test
{
    using LambdaCore_Skeleton;
    using LambdaCore_Skeleton.Interfaces;
    using LambdaCore_Skeleton.Models.Cores;
    using LambdaCore_Skeleton.UI;

    [TestClass]
    public class LambdaCoreTest
    {
        private IPowerPlant powerPlant;

        [TestInitialize]
        public void Init()
        {
           this.powerPlant = new PowerPlant(new ConsoleWriter(), new ConsoleReader()); 
        }

        [TestMethod]
        public void TestSelectCommandShoudSetCurrentlyCoreToSelectedCoreProperty()
        {
            this.powerPlant.Cores.Add(new ParaBaseCore('A', 1000));
            var select = new ParaBaseCore('B', 2000);
            this.powerPlant.Cores.Add(select);
            this.powerPlant.Cores.Add(new SystemBaseCore('C', 10900));

            this.powerPlant.SelectCore("B");

            Assert.AreEqual(this.powerPlant.SelectedCore, select);
        }
    }
}
