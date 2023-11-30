
using Homework;

class Program
{
    static void Main(string[] args)
    {
        // H-W 11.1 Bank accounts
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
        Console.WriteLine("Press any key to continue");
        Console.ReadKey();
    }
}