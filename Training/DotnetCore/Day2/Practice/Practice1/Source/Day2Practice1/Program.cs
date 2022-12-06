using System;

namespace Day2Practice1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var account = new BankAccount("Chaitanya", 1000);
            Console.WriteLine($"Account {account.Number} was created for {account.Owner}");

            account.MakeWithdrawal(500, DateTime.Now, "Rent payment");
            Console.WriteLine(account.Balance);
            account.MakeDeposit(100, DateTime.Now, "Friend paid me back");
            Console.WriteLine(account.Balance);
        }
    }
}
