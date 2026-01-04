using System;

class Order
{
    public int OrderId;
    public string OrderDate;

    public Order(int orderId, string orderDate)
    {
        OrderId = orderId;
        OrderDate = orderDate;
    }

    //Method to return order status
    public virtual string GetOrderStatus()
    {
        return "Order Placed";
    }
}
