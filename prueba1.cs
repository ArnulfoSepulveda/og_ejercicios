public void ProcessOrder(Order order)
{
    // Validate order
    if (order == null || order.Items.Count == 0)
    {
        throw new ArgumentException("Invalid order");
    }

    // Calculate total price
    decimal total = 0;
    foreach (var item in order.Items)
    {
        total += item.Price * item.Quantity;
    }

    // Apply discount
    if (order.Customer.IsPreferred)
    {
        total *= 0.9m; // 10% discount
    }

    // Print receipt
    Console.WriteLine($"Order total: {total:C}");
}