namespace BankNamespace
{
    public class AccountFactory
    {
        public Dictionary<int, BankAccount> accounts = new Dictionary<int, BankAccount>();

        public int nextAccountNumber = 1;

        public int CreateAccount()
        {
            BankAccount account = new BankAccount(nextAccountNumber);
            accounts.Add(nextAccountNumber, account);

            nextAccountNumber++;

            return account.Number;
        }

        public int CreateAccount(decimal initialBalance)
        {
            BankAccount account = new BankAccount(nextAccountNumber, initialBalance);
            accounts.Add(nextAccountNumber, account);

            nextAccountNumber++;

            return account.Number;
        }

        public void CloseAccount(int number)
        {
            accounts.Remove(number);
        }
    }
}