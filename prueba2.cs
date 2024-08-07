public class OrderService
{
    public void ProcessOnlineOrder(Order order)
    {
        // Common validation
        if (order == null || order.Items.Count == 0)
        {
            throw new ArgumentException("Invalid order");
        }
        // Specific logic for online orders
        // ...
    }

    public void ProcessInStoreOrder(Order order)
    {
        // Common validation
        if (order == null || order.Items.Count == 0)
        {
            throw new ArgumentException("Invalid order");
        }
        // Specific logic for in-store orders
        // ...
    }
}