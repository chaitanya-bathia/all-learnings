using System;
using System.Collections.Generic;
using System.Text;

namespace Day2Practice1
{
    internal class BankAccount
    {
        private static int accountNumberSeed = 1001;
        public string Number { get; }
        public string Owner { get; set; }
        public decimal Balance { get
            {
                decimal balance = 0;
                foreach (var item in allTransactions)
                {
                    balance += item.Amount;
                }

                return balance;
            }
        }
     
        public BankAccount(string owner, decimal initialBalance)
        {
            this.Owner = owner;
            MakeDeposit(initialBalance, DateTime.Now, "Initial Balance");

            this.Number = accountNumberSeed.ToString();
            accountNumberSeed++;
        }

        private List<Transaction> allTransactions = new List<Transaction>();

        public void MakeDeposit(decimal amount, DateTime date, string note)
        {
            if(amount <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(amount),"Amount of deposit Must be Positive");
            }
            var deposit = new Transaction(amount, date, note);
            allTransactions.Add(deposit);
        }

        public void MakeWithdrawal(decimal amount, DateTime date, string note)
        {
            if(amount < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(amount), "Amount of withdrawal Must be Positive");
            }
            if(Balance - amount < 0)
            {
                throw new InvalidOperationException("Not Sufficient Funds for this withdrawal");
            }
            var withdrawal = new Transaction(-amount, date, note);
            allTransactions.Add(withdrawal);
        }


    }
}
