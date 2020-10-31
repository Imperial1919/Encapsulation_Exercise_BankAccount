using System;
using System.Collections.Generic;
using System.Text;

namespace Bank_Encapsulation
{
    class BankAccount
    {
        private double _balance = 0;


        public double Balance {
       
            get
                {
                return _balance;
            }

            set
            {
                _balance = value;
            }

        }


    
        public double GetBalance()
        {
            return Balance;
        }

        public double Deposit(double DepositAmount)
        {

            Balance =+ DepositAmount;
            return Balance;
        }

        public void Withdraw(double WithdrawAmount)
        {
            Balance = -WithdrawAmount;
        }


    }
}
