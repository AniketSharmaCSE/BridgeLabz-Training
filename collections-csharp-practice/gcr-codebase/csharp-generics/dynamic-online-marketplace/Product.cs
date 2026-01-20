public class Product<T> : ProductBase
{
    public T Category { get; set; }

    public Product(string name, double price, T category)
        : base(name, price)
    {
        Category = category;
    }

    public override void Display()
    {
        Console.WriteLine(
            "Product: " + Name +
            ", Price: " + Price +
            ", Category: " + Category
        );
    }
}
