using Microsoft.VisualStudio.TestTools.UnitTesting;
using PremiumCarsRacing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PremiumCarsRacing.Tests
{
    [TestClass()]
    public class Form2Tests
    {
        [TestMethod()]
        public void Form2Test()
        {
            runer run = new runer();
            if (run.stp() == 900)
            {
                Assert.IsTrue(true);
            }
            else {
                Assert.IsTrue(false);
            }

        }

        [TestMethod()]
        public void Form3Test()
        {
            RceTsk run = new RceTsk();
            if (run.setting(1) == 1)
            {
                Assert.IsTrue(true);
            }
            else
            {
                Assert.IsTrue(false);
            }

        }
    }
}