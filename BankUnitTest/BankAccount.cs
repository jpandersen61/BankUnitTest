using System;
using System.Collections.Generic;
using System.Text;

namespace BankUnitTest
{
    public class BankAccount
    {
        #region Instance fields
        private double _balance;
        private double _credit;
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
        public double Credit
        {
            get { return _credit; }
            set { _credit = value; }
        }
        #endregion

        #region Methods
        public void Deposit(double amount)
        {
            if (amount < 0)
            {
                throw new ArgumentOutOfRangeException("Amount negative");
            }
            _balance += amount;
        }

        public void Withdraw(double amount)
        {
            if (amount < 0)
            {
                throw new ArgumentOutOfRangeException("Amount negative");
            }

            if ((_balance - amount) < _credit)
            {
                throw new NegativeBalanceException();
            }

            _balance -= amount;
        }
        #endregion
    }
}
