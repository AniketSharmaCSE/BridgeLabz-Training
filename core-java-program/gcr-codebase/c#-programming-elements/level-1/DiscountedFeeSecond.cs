using System;

public class DiscountedFeeSecond
{
    public static void Main(string[] args)
    {
        //take input for fee and discount percentage
		Console.WriteLine("Enter the fee: ");
        double Fee=Convert.ToDouble(Console.ReadLine());
		Console.WriteLine("Enter the Discount Percent: ");
        double DiscountPercent=Convert.ToDouble(Console.ReadLine());

        //calculate discounted amount
        double DiscountedAmount=(Fee*DiscountPercent)/100.0;

        //calculate final fee to pay
        double FeeToPay=Fee-DiscountedAmount;

        //print the result
        Console.WriteLine("The discount amount is INR "+DiscountedAmount+" and final discounted fee is INR "+FeeToPay);
    }
}
