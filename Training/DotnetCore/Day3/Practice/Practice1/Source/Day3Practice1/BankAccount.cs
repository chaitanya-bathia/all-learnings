using System;
using System.Collections.Generic;
using System.Text;

namespace Day3Practice1
{
    public class BankAccount
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

        private readonly decimal _minimumBalance;
        public BankAccount(string owner, decimal initialBalance) : this(owner, initialBalance, 0) { }

        public BankAccount(string owner,decimal initialBalance, decimal minimumBalance)
        {
            this.Number = accountNumberSeed.ToString();
            accountNumberSeed++;
            
            _minimumBalance = minimumBalance;
            
            this.Owner = owner;
            if (initialBalance > 0)
            { 
                MakeDeposit(initialBalance, DateTime.Now, "Initial Balance"); 
            }

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
            if(Balance - amount < _minimumBalance)
            {
                throw new InvalidOperationException("Not Sufficient Funds for this withdrawal");
            }
            var withdrawal = new Transaction(-amount, date, note);
            allTransactions.Add(withdrawal);
        }

        public string GetAccountHistory()
        {
            var report = new System.Text.StringBuilder();

            decimal balance = 0;
            report.AppendLine("Date\t\tAmount\tBalance\tNote");
            foreach (var item in allTransactions)
            {
                balance += item.Amount;
                report.AppendLine($"{item.Date.ToShortDateString()}\t{item.Amount}\t{balance}\t{item.Notes}");
            }

            return report.ToString();
        }

        public virtual void PerformMonthEndTransactions() { }
    }
}
