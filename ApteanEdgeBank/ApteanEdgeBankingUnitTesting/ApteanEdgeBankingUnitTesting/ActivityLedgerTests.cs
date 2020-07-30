using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ApteanEdgeBankDataLayer;
using System.Linq;

namespace ApteanEdgeBankingUnitTesting
{
    [TestClass]
    public class ActivityLedgerTests
    {

        [TestMethod]
        public void GetAllTheActivity_UnKnownAccountActivityAccessed_ReturnsZero()
        {
            //Arrange
            int expected = 0;
            ActivityDL activityDL = new ActivityDL();
            //Act
            var result = activityDL.GetAllTheActivity(999999999999999999.ToString()).Count();
            //Assert
            Assert.AreEqual(expected,result);
        }
        [TestMethod]
        public void Calculate_CalculatingUnKnownAccount_ReturnsZero()
        {
            //Arrange
            double expected = 0;
            ActivityDL activityDL = new ActivityDL();
            //Act
            var result = activityDL.Calculate(999999999999999999);
            //Assert
            Assert.AreEqual(expected,result);
        }

    }
}
