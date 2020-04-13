using System;
using BankyStuffLibrary;

namespace MySuperBank
{
    class Program
    {
        static void Main(string[] args)
        {
            var account = new BankAccount("Fer", 1000);
            Console.WriteLine($"Account {account.Number} was created for {account.Owner} with {account.Balance}.");

            account.MakeWithdrawal(200, DateTime.Now, "Sampler");
            account.MakeWithdrawal(240, DateTime.Now, "Synth");
            account.MakeWithdrawal(540, DateTime.Now, "Another Synth");

            Console.WriteLine(account.GetAccountHistory());
            Console.WriteLine($"Current balance: {account.Balance}");
        }
    }
}
