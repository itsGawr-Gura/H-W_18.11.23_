using BankNamespace;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankLibrary
{
    public class BankAccount1
    {
        public int Number { get; set; }
        public decimal Balance { get; set; }

        public override bool Equals(object obj)
        {
            var other = obj as BankAccount1;
            if (other == null) return false;
            return Number == other.Number && Balance == other.Balance;
        }

        public override int GetHashCode()
        {
            return Number; 
        }

        public static bool operator ==(BankAccount1 a, BankAccount1 b)
        {
            if (a is null && b is null) return true;
            if (a is null || b is null) return false;
            return a.Equals(b);
        }

        public static bool operator !=(BankAccount1 a, BankAccount1 b)
        {
            return !(a == b);
        }

        public override string ToString()
        {
            return $"Номер: {Number}; Баланс: {Balance}";
        }
    }
}
