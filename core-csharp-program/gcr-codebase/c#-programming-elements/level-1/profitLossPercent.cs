using System;

public class profitLossPercent{
	static void Main(){
		double costPrice = 129;
		double sellingPrice = 191;
		double profit = sellingPrice - costPrice;
		double profitPercent = (profit/costPrice) * 100;
		Console.WriteLine("The Cost Price Is INR "+costPrice + " and the Selling Price is INR "+sellingPrice + " The Profit is INR "+profit + " and The profit percent is INR "+profitPercent);
	}
}