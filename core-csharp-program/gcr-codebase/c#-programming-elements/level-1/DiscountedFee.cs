public class DiscountedFee{
	public static void Main(String[] args){
		//define fee value and discount percent
		int Fee = 125000, DiscountPercent = 10;
		
		//calculate discounted amount
		double DiscountedAmount = (Fee*DiscountPercent)/100;
		//calculate actual fee to be paid
		double FeeToPay = Fee - DiscountedAmount;
		
		//Print the result
		Console.WriteLine("The discount amount is INR "+DiscountedAmount+ " and final discounted fee is INR "+FeeToPay );
		
		
	}

}