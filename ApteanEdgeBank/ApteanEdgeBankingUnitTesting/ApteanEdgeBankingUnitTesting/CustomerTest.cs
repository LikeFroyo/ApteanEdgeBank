using System;
using ApteanEdgeBankDataLayer;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ApteanEdgeBankingUnitTesting
{
    [TestClass]
    public class CustomerTest
    {
        [TestMethod]
        public void AddCustomer_UserIsAdded_ReturnsTrue()
        {
            //Arrange
            bool expected = true;
            CustomerDL customerDL = new CustomerDL();
            //Act
            bool actual = customerDL.AddCustomer("TestCase First", DateTime.Now, 1);
            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void AddCustomer_UserTryingToAddInUnKnownBranch_ReturnsFalse()
        {
            //Arrange
            bool expected = false;
            CustomerDL customerDL = new CustomerDL();
            //Act
            bool actual = customerDL.AddCustomer("TestCase First", DateTime.Now, 7);
            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void UpdateCustomer_UnKnownUserIsUpdated_ReturnsFalse()
        {
            //Arrange
            bool expected = false;
            CustomerDL customerDL = new CustomerDL();
            //Act
            bool actual = customerDL.UpdateCustomer(999999999999999999, "TestCase First", DateTime.Now, 1);
            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void UpdateCustomer_KnownUserIsUpdated_ReturnsTrue()
        {
            //Arrange
            bool expected = true;
            CustomerDL customerDL = new CustomerDL();
            //Act
            bool actual = customerDL.UpdateCustomer(10000000069, "TestCas", DateTime.Today, 1);
            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GetCustomerDetail_UnKnownUserIsAccessed_ReturnsFalse()
        {
            //Arrange
            Customer expected = null;
            CustomerDL customerDL = new CustomerDL();
            //Act
            Customer actual = customerDL.GetCustomerDetail(999999999999999999);
            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GetCustomerDetail_KnownUserIsAccessed_ReturnsNotNull()
        {
            //Arrange
            CustomerDL customerDL = new CustomerDL();
            //Act
            Customer result = customerDL.GetCustomerDetail(10000000077);
            //Assert
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void GetCustomerAccounts_KnownUserAccountsAccessed_ReturnsNotNull()
        {
            //Arrange
            CustomerDL customerDL = new CustomerDL();
            //Act
            var result = customerDL.GetCustomerAccount(10000000077);
            //Assert
            Assert.IsNotNull(result);
        }
    }
}
