public class Customer
{
    private int customerId;
    private string[] items;

    public Customer(int customerId, string[] items)
    {
        this.customerId = customerId;
        this.items = items;
    }

    public int GetCustomerId()
    {
        return customerId;
    }

    public string[] GetItems()
    {
        return items;
    }
}
