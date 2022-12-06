using System;
using System.Collections.Generic;
using System.Text;

namespace Day3Practice1
{
    public class GiftCardAccount : BankAccount
    {
        private readonly Decimal _monthlyDeposit = 0m;
        public GiftCardAccount(string owner, decimal initialBalance, decimal monthlyDeposit) : base(owner, initialBalance) => _monthlyDeposit = monthlyDeposit;

        public override void PerformMonthEndTransactions()
        {
            if(_monthlyDeposit !=0)
            {
                MakeDeposit(_monthlyDeposit, DateTime.Now, "Added monthly Deposit.");
            }    
        }
    }
}
