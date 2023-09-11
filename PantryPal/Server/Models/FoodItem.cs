namespace PantryPal.Server.Models;

public class FoodItem
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public DateTime PurchaseDate { get; set; }
    public DateTime ExpirationDate { get; set; }
    public int Quantity { get; set; }
}
