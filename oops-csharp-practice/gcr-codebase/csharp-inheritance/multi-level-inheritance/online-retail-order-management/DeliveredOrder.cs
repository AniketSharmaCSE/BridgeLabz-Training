using System;

class DeliveredOrder : ShippedOrder
{
    public string DeliveryDate;

    public DeliveredOrder(int orderId, string orderDate, string trackingNumber, string deliveryDate)
        : base(orderId, orderDate, trackingNumber)
    {
        DeliveryDate = deliveryDate;
    }

    //Override to update order status
    public override string GetOrderStatus()
    {
        return "Order Delivered";
    }
}
