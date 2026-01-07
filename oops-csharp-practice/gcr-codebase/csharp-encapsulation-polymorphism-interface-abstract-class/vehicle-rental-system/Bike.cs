using System;

public class Bike : Vehicle, IInsurable
{
    private string insurancePolicyNumber;

    public Bike(double rentalRatePerDay, string insurancePolicyNumber)
    {
        this.rentalRatePerDay = rentalRatePerDay;
        this.insurancePolicyNumber = insurancePolicyNumber;
    }

    public override double CalculateRentalCost(int totalDays)
    {
        return rentalRatePerDay * totalDays;
    }

    public double CalculateInsurance()
    {
        return 200;
    }

    public string GetInsuranceDetails()
    {
        return insurancePolicyNumber;
    }
}
