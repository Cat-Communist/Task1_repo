using Microsoft.VisualStudio.TestTools.UnitTesting;
using Task1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1.Tests
{
    [TestClass()]
    public class LogicTests
    {
        [TestMethod()]
        public void wordForm1suite()
        {
            // Arrange + Action
            string rubles = Logic.wordForm(11, "rubles");
            string cents = Logic.wordForm(11, "cents");

            // Assert
            Assert.AreEqual(rubles, " рублей");
            Assert.AreEqual(cents, " копеек");
        }

        [TestMethod()]
        public void wordForm2suite()
        {
            // Arrange + Action
            string rubles = Logic.wordForm(21, "rubles");
            string cents = Logic.wordForm(21, "cents");

            // Assert
            Assert.AreEqual(rubles, " рубль");
            Assert.AreEqual(cents, " копейка");
        }

        [TestMethod()]
        public void wordForm3suite()
        {
            // Arrange + Action
            string rubles = Logic.wordForm(24, "rubles");
            string cents = Logic.wordForm(24, "cents");

            // Assert
            Assert.AreEqual(rubles, " рубля");
            Assert.AreEqual(cents, " копейки");
        }

        [TestMethod()]
        public void wordForm4suite()
        {
            // Arrange + Action
            string rubles = Logic.wordForm(25, "rubles");
            string cents = Logic.wordForm(25, "cents");

            // Assert
            Assert.AreEqual(rubles, " рублей");
            Assert.AreEqual(cents, " копеек");
        }

        [TestMethod()]
        public void wordFormArgTest()
        {
            // Action
            try
            {
                Logic.wordForm(12, "Huh?");
            }

            // Assert
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }
        }
    }
}