namespace CustomerPortalService.Shared;

public class PurchaseOrder
{
    public string OrderNumber { get; set; }
    public DateTime OrderDate { get; set; }
    public Customer Customer { get; set; }
    public List<OrderedItem> OrderedItem { get; set; }
}

public class Customer
{
    public int CustomerId { get; set; }
    public string Name { get; set; }
}

public class OrderedItem
{
    public int ProductId { get; set; }
    public int Quantity { get; set; }
}