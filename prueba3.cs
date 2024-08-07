public decimal CalculateDiscount(Order order)
{
    if (order.Customer.IsPreferred)
    {
        if (order.Total > 100)
        {
            return order.Total * 0.1m;
        }
        else
        {
            return order.Total * 0.05m;
        }
    }
    else
    {
        if (order.Total > 100)
        {
            return order.Total * 0.02m;
        }
        else
        {
            return 0;
        }
    }
}