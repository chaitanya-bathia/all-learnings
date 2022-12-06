using System;
using System.Collections.Generic;
using System.Text;

namespace Day3Practice1
{
    public class InterestEarningAccount : BankAccount
    {
        public InterestEarningAccount(string owner, decimal initialBalance) : base(owner, initialBalance)
        {
        }

        public override void PerformMonthEndTransactions()
        {
            if(Balance > 500)
            {
                decimal interest = Balance * 0.05m;
                MakeDeposit(interest, DateTime.Now, "apply monthly interest");
            }
        }
    }
}
