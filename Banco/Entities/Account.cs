using System;
using System.Collections.Generic;
using System.Text;
using Banco.Entities.Exception;

namespace Banco.Entities
{
    class Account
    {
        public int Number { get; set; }
        public string Holder { get; set; }
        public double Balance { get; set; }
        public double WithdrawLimit { get; set; }

        public Account()
        {

        }

        public Account(double balance)
        {
            Balance = balance;
        }

        public Account(int number, string holder, double balance, double withdrawLimit)
        {
            Number = number;
            Holder = holder;
            Balance = balance;
            WithdrawLimit = withdrawLimit;
        }

        public void Deposit(double amount)
        {
            Balance += amount;
        }

        public void Withdraw(double amount)
        {
            if (amount > WithdrawLimit)
            {
                throw new DomainException("A QUANTIA ESTA ACIMA DO LIMITE DO SEU SAQUE!!!");
            }
          
            else if ( Balance < amount)
            {
                throw new DomainException("SALDO DA CONTA INSUFICIENTE!!!");
            }

            else
            {
                Balance -= amount;
            }           
        }







    }
}
