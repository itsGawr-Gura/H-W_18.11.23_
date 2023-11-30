using System.Collections.Generic;
using Program;

namespace BankNamespace
{
    public class BankAccount
    {
        public int Number { get; private set; }
        public decimal Balance { get;  set; }

        public BankAccount(int number)
        {
            Number = number;
        }

        public BankAccount(int number, decimal initialBalance) : this(number)
        {
            Balance = initialBalance;
        }
    }
}
