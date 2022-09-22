using Microsoft.VisualStudio.TestTools.UnitTesting;
using BankUnitTest;

namespace TestAccount
{
    [TestClass]
    public class UnitTest1
    {
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
        }

    }
}
