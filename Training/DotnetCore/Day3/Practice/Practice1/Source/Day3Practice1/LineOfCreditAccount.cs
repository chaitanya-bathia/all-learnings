using System;
using System.Collections.Generic;
using System.Text;

namespace Day3Practice1
{
    public class LineOfCreditAccount : BankAccount
    {
        public LineOfCreditAccount(string owner, decimal initialBalance,decimal creditLimit) : base(owner, initialBalance ,-creditLimit)
        {
        }

        public override void PerformMonthEndTransactions()
        {
            if (Balance < 0)
            {
                decimal interest = -Balance * 0.07m;
                MakeWithdrawal(interest, DateTime.Now, "Charge monthly interest");
            }
        }
    }
}
