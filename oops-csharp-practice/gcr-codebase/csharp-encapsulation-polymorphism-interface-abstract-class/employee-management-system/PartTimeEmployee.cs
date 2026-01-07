using System;

public class PartTimeEmployee : Employee
{
    private int hours;
    private int ratePerHour;

    public PartTimeEmployee(int hours, int ratePerHour)
    {
        this.hours = hours;
        this.ratePerHour = ratePerHour;
    }

    public override double CalculateSalary()
    {
        return hours * ratePerHour;
    }
}
