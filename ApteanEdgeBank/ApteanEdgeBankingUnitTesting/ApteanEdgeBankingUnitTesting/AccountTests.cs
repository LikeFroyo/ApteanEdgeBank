using System;
using ApteanEdgeBankDataLayer;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ApteanEdgeBankingUnitTesting
{
    [TestClass]
    public class AccountTests
    {
        [TestMethod]
        public void AddAccount_OpeningChequingForExistingCustomerAccount_ReturnsTrue()
        {
            //Arrange
            bool expected = true;
            AccountDL accountDL = new AccountDL();
            //Act
            bool actual = accountDL.AddAccount(10000000068,DateTime.Now, 1,1);
            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void AddAccount_OpeningLiabilityForExistingCustomerAccount_ReturnsTrue()
        {
            //Arrange
            bool expected = true;
            AccountDL accountDL = new AccountDL();
            //Act
            bool actual = accountDL.AddAccount(10000000068, DateTime.Now, 1, 3);
            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void AccountHandle_ClosingUnknownCustomerAccount_ReturnsFalse()
        {
            //Arrange
            bool expected = false;
            AccountDL accountDL = new AccountDL();
            //Act
            bool actual = accountDL.AddAccount(999999999999999999, DateTime.Now, 1, 3);
            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void AccountCreditOrWithdraw_WithdrawMoreThanTotalBankBalance_ReturnsFalse()
        {
            //Arrange
            bool expected = false;
            AccountDL accountDL = new AccountDL();
            //Act
            bool actual = accountDL.AccountCreditOrWithdraw(10000000068, 213123123123121312321.312312);
            //Assert
            Assert.AreEqual(expected, actual);
        }


        [TestMethod]
        public void AccountCreditOrWithdraw_WithdrawMoreThanTotalAccountBalance_ReturnsFalse()
        {
            //Arrange
            bool expected = false;
            AccountDL accountDL = new AccountDL();
            //Act
            bool actual = accountDL.AccountCreditOrWithdraw(10000000068, 213123);
            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void AccountCreditOrWithdraw_WithdrawLessThanTotalAccountBalance_ReturnsTrue()
        {
            //Arrange
            bool expected = true;
            AccountDL accountDL = new AccountDL();
            //Act
            bool actual = accountDL.AccountCreditOrWithdraw(10000000068, 0);
            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
