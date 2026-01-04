using System;

public class CarRental
{
    string customerName;
    string carModel;
    int rentalDays;


    //Parameterized constructor to initialize rental details
    public CarRental(string customerName, string carModel, int rentalDays){
        this.customerName = customerName;
        this.carModel = carModel;
        this.rentalDays = rentalDays;
    }
	

    //Method to calculate total rental cost
    public void CalculateTotalCost()
    {
        int costPerDay = 1000;
        int totalCost = rentalDays * costPerDay;
		
        Console.WriteLine("Total Cost: " + totalCost);
    }
}
