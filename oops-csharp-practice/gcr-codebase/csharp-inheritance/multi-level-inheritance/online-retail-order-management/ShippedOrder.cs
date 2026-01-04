using System;

class ShippedOrder : Order
{
    public string TrackingNumber;

    public ShippedOrder(int orderId, string orderDate, string trackingNumber)
        : base(orderId, orderDate)
    {
        TrackingNumber = trackingNumber;
    }

    //Override to update order status
    public override string GetOrderStatus()
    {
        return "Order Shipped";
    }
}
