using System;

public class Car : Vehicle, IInsurable
{
    private string insurancePolicyNumber;

    public Car(double rentalRatePerDay, string insurancePolicyNumber)
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
        return 500;
    }

    public string GetInsuranceDetails()
    {
        return insurancePolicyNumber;
    }
}
