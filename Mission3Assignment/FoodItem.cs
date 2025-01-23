namespace Mission3Assignment;

public class FoodItem
{
    public string Name { get; set; }
    public string Category { get; set; }
    public int Quantity { get; set; }
    public DateTime ExpirationDate { get; set; }

    // Constructor to initialize a food item
    public FoodItem(string name, string category, int quantity, DateTime expirationDate)
    {
        Name = name;
        Category = category;
        Quantity = quantity;
        ExpirationDate = expirationDate;
    }

    // Override ToString for easier display
    public override string ToString()
    {
        return $"{Name} | {Category} | {Quantity} units | Expires: {ExpirationDate.ToShortDateString()}";
    }
}