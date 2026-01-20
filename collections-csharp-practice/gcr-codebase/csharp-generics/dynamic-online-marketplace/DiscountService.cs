public class DiscountService
{
    public void ApplyDiscount<T>(T product, double percentage)
        where T : ProductBase
    {
        double discount = product.Price * percentage / 100;
        product.Price = product.Price - discount;
    }
}
