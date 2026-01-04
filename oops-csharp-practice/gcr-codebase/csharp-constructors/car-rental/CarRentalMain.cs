using System;

public class CarRentalMain
{
    static void Main(string[] args)
    {
        //Taking user input
        Console.WriteLine("Enter customer name:");
        string name = Console.ReadLine();
        Console.WriteLine("Enter car model:");
        string model = Console.ReadLine();
        Console.WriteLine("Enter rental days:");
        int days = Convert.ToInt32(Console.ReadLine());
		
        CarRental rental = new CarRental(name, model, days);
        rental.CalculateTotalCost();
    }
}
