namespace P01_SalesDatabase.Models;

public class Sale
{
    public int SaleId { get; set; }
    public int CustomerId { get; set; }
    public int ProductId { get; set; }
    public int StoreId { get; set; }
}