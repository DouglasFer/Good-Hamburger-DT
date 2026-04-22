namespace GoodHamburger.Shared.Models;

public class Order
{
    public Guid Id { get; set; }
    public Product Sandwich { get; set; }
    public Product? Side { get; set; }
    public Product? Drink { get; set; }

    public decimal Subtotal { get; set; }
    public decimal Discount { get; set; }
    public decimal Total { get; set; }
}