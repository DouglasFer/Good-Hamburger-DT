namespace GoodHamburger.Shared.Models;

public class Product
{
    public string Name { get; set; }
    public decimal Price { get; set; }
    public ItemType Type { get; set; }
}