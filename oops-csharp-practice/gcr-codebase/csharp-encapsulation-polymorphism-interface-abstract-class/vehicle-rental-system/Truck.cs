using System;

public class Truck : Vehicle, IInsurable
{
    private string insurancePolicyNumber;

    public Truck(double rentalRatePerDay, string insurancePolicyNumber)
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
        return 1000;
    }

    public string GetInsuranceDetails()
    {
        return insurancePolicyNumber;
    }
}
