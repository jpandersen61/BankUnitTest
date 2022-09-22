using System;
using System.Collections.Generic;
using System.Text;

namespace BankUnitTest
{
    public class BankAccount
    {
        #region Instance fields
        private double _balance;
        #endregion

        #region Constructor
        public BankAccount()
        {
            _balance = 0.0;
        }
        #endregion

        #region Properties
        public double Balance
        {
            get { return _balance; }
        }
        #endregion

        #region Methods
        public void Deposit(double amount)
        {
            _balance += amount;
        }

        public void Withdraw(double amount)
        {
            if (amount < 0)
            {
                throw new ArgumentOutOfRangeException("Amount negative");
            }
            _balance -= amount;
        }
        #endregion
    }
}
