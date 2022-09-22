using Microsoft.VisualStudio.TestTools.UnitTesting;
using BankUnitTest;
using System;


namespace TestAccount
{
    [TestClass]
    public class AccountUnitTest
    {
        
        //Testing 'sunshine' (intended) scenarios starts here
        
        [TestMethod]
        public void TestDeposit()
        {
            BankAccount ba = new BankAccount();
            double balance = ba.Balance;
            double amountToDeposit = 42.85;
            ba.Deposit(amountToDeposit);
            Assert.AreEqual(balance + amountToDeposit, ba.Balance);
        }

        [TestMethod]
        public void TestWithDraw()
        {
            BankAccount ba = new BankAccount();
            double balance = ba.Balance;
            double amountToDeposit = 42.85;            
            ba.Deposit(amountToDeposit);
            double amountToWithdraw = 10;
            ba.Withdraw(amountToWithdraw);
            Assert.AreEqual(balance + amountToDeposit - amountToWithdraw, 
                            ba.Balance);
        }

        //Test exception (NOT intended) scenarios starts here

        [TestMethod]
        public void TestNegativWithDrawAmount()
        {
            BankAccount ba = new BankAccount();
            try
            {
                //We try to withdraw a negative amount -> Test should fail
                ba.Withdraw(-42);

                //If we reach the test has failed
                Assert.Fail("Did NOT catch exception on negative withdraw");
            }
            catch (ArgumentException e)
            {
                //OK, if we reach here -> Expected exception caught -> Test passed
            }
        }

        [TestMethod]
        public void TestNegativDepositAmount()
        {        
            BankAccount ba = new BankAccount();
            try
            {
                //We try to deposit a negative amount -> Test should fail
                ba.Deposit(-42);

                //If we reach the test has failed
                Assert.Fail("Did NOT catch exception on negative deposit");
            }
            catch (ArgumentOutOfRangeException e)
            {
                //OK, if we reach here -> Expected exception caught -> Test passed
            }
        }

        [TestMethod]
        public void TestNegativBalance()
        {
            BankAccount ba = new BankAccount();
            double currentBalance = ba.Balance;
            try
            {
                //We try to withdraw current balance plus -> Test should fail
                ba.Withdraw(currentBalance+1);

                //If we reach the test has failed
                Assert.Fail("Did NOT catch exception on negative balance");
            }
            catch (NegativeBalanceException e)
            {
                //OK, if we reach here -> Expected exception caught -> Test passed
            }
        }
    }
}
