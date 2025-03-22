namespace P01_SalesDatabase.Models;

public class Product
{
    public int ProductId { get; set; }
    public string Name { get; set; }
    public decimal Price { get; set; }
    public double Quantity { get; set; }
    public ICollection<Sale> Sales { get; set; } 
}