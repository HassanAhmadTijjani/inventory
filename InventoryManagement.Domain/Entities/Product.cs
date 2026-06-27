namespace InventoryManagement.Domain.Entities;

public class Product
{
    public Guid Id { get; private set; }
    public string Name { get; private set; } = string.Empty;
    public string Description { get; private set; } = string.Empty;
    public decimal Price { get; private set; }
    public int Quantity { get; private set; }
    public int LowStockThreshold { get; private set; }
    public DateTime CreatedAt { get; private set; }
    public bool IsLowStock => Quantity <= LowStockThreshold;
    private Product() { }
    public Product(string name, string description, decimal price, int quantity, int lowStockThreshold)
    {
        Id = Guid.NewGuid();

        Name = name;
        Description = description;
        Price = price;
        Quantity = quantity;
        LowStockThreshold = lowStockThreshold;
        CreatedAt = DateTime.UtcNow;
    }
    public void Update(
        string name,
        string description,
        decimal price,
        int quantity,
        int lowStockThreshold

    )
    {
        if (string.IsNullOrWhiteSpace(name))
        {
            throw new ArgumentException("Name must not be empty");
        }
        if (price < 0)
        {
            throw new ArgumentException("Price must not be negative");
        }
        if (quantity < 0)
        {
            throw new ArgumentException("Quantity must not be negative");
        }
        if (lowStockThreshold < 0)
        {
            throw new ArgumentException("Low stock threshold must not be empty");
        }
        Name = name;
        Description = description;
        Price = price;
        Quantity = quantity;
        LowStockThreshold = lowStockThreshold;
    }
}
