using System;

namespace MySuperBank
{
    class Program
    {
        static void Main(string[] args)
        {
            var account = new BankAccount("Kendra", 10000);
            Console.WriteLine($"Account {account.Number} was created for {account.Owner} with {account.Balance}");

            account.MakeWithdrawl(120, DateTime.Now, "Hammock");
            Console.WriteLine($"account balance is - {account.Balance}");
        }
    }
}
