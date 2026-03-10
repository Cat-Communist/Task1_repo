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
        public void ZeroCents()
        {
            // Arrange
            int price = 300;

            // Action
            string res = Logic.UpdateCase(price);

            // Assert
            Assert.AreEqual("3 рубля ровно", res);
        }

        [TestMethod()]
        public void ZeroRubles()
        {
            // Arrange
            int price = 99;

            // Action
            string res = Logic.UpdateCase(price);

            // Assert
            Assert.AreEqual("99 копеек", res);
        }

        [TestMethod()]
        public void Nominative()
        {
            // Arrange
            int price = 101;

            // Action
            string res = Logic.UpdateCase(price);

            // Assert
            Assert.AreEqual("1 рубль 1 копейка", res);
        }

        [TestMethod()]
        public void GenitivePlural()
        {
            // Arrange
            int price1 = 1414;
            int price2 = 2626;

            // Action
            string res1 = Logic.UpdateCase(price1);
            string res2 = Logic.UpdateCase(price2);  

            // Assert
            Assert.AreEqual("14 рублей 14 копеек", res1);
            Assert.AreEqual("26 рублей 26 копеек", res2);
        }

        [TestMethod()]
        public void GenitiveSingular()
        {
            int price = 2323;
            string res = Logic.UpdateCase(price);
            Assert.AreEqual("23 рубля 23 копейки", res);
        }
    }
}