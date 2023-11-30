using BankNamespace;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            // EX 11.1 Bank accounts
            Console.WriteLine("Bank accounts");
            AccountFactory factory = new AccountFactory();
            int account1 = factory.CreateAccount(100);
            int account2 = factory.CreateAccount();
            BankAccount acc1 = factory.accounts[account1];
            BankAccount acc2 = factory.accounts[account2];
            acc1.Balance += 50;
            Console.WriteLine(acc1.Number);
            Console.WriteLine(acc1.Balance);
            factory.CloseAccount(account1);
            Console.WriteLine("Opened accounts: " + factory.accounts.Count);
            // H-W 11.1 Bank accounts
            Console.WriteLine("Press any key to continue");
            Console.ReadKey();
        }
    }
}