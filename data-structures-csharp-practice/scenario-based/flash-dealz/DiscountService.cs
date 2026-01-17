using System;

public class DiscountService
{
    public void CalculateAndApplyDiscount(Product product, double percentage)
    {
        product.ApplyDiscount(percentage);
    }
}
