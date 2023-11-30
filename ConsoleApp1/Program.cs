using BankNamespace;
using Homework;
using BankLibrary;
using Lab_Tumakov;
class Program
{
    static void Main(string[] args)
    {
        // EX 11.1 Bank accounts
        Console.WriteLine("---------------------");
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
        Console.WriteLine("---------------------");
        // H-W 11.1 Bank accounts
        Console.WriteLine("Building");
        Building building1 = Creator.CreateBuilding(1, 100, 5, "Lenina st, 1");
        if (Creator.DeleteBuilding(1))
        {
            Console.WriteLine("Building deleted");
        }

        Building building2 = Creator.CreateBuilding(2, 200, 10, "Gagarina st, 25");
        Console.WriteLine($"Id: {building2.GetId()}");
        Console.WriteLine($"Square: {building2.GetSquare()}");
        Console.WriteLine($"Floors: {building2.GetFloors()}");
        Console.WriteLine($"Address: {building2.GetAddress()}");
        Console.WriteLine("---------------------");
        // Ex 12.1 Bank account
        Console.WriteLine("Ex 12.1 Bank account");
        BankAccount1 account3 = new BankAccount1 { Number = 3, Balance = 100 };
        BankAccount1 account4 = new BankAccount1 { Number = 4, Balance = 100 };
        Console.WriteLine($"account3 == account4 - {account3 == account4}"); 
        Console.WriteLine(account3.Equals(account4)); 
        Console.WriteLine(account3.GetHashCode());
        Console.WriteLine(account3); 
        Console.WriteLine(account4);
        Console.WriteLine("---------------------");
        // H-W 12.1 Complex
        Complex c1 = new Complex(1, 2);
        Complex c2 = new Complex(3, 4);
        Console.WriteLine(c1 + c2);
        // H-W 12.2 Sort Books
        Console.WriteLine("---------------------");
        Book book1 = new Book("Black House", "Stevn King", "For All");
        Book book2 = new Book("Infinity Blood Core", "Gu Zhen Ren", "Gu House");
        Book book3 = new Book("Reverend Insanity", "Gu Zhen Ren", "Gu House");
        Book[] books = new Book[] { book1, book2, book3 };
        BookContainer container = new BookContainer(books);

        Comparison<Book> comparison = (bookA, bookB) => bookA.Title.CompareTo(bookB.Title);

        container.SortBooks(comparison);

        foreach (Book book in books)
        {
            Console.WriteLine($"Name: {book.Title}, Autor: {book.Author}, Publisher: {book.Publisher}");
        }
        Console.WriteLine("Press any key to continue");
        Console.ReadKey();
    }
}