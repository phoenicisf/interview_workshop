public class Order
{
    public int Id { get; set; }
    public List<OrderItem> Items { get; set; } = new();
    public DateTime OrderDate { get; set; }
}

public class OrderItem
{
    public int ProductId { get; set; }
    public int Quantity { get; set; }
    public decimal Price { get; set; }
}


public class Product
{
    public int ProductId { get; set; }
    public decimal Price { get; set; }

    public List<Product> SampleProducts (int rows)
    {
        var random = new Random();
        var products = new List<Product>();
        for (int j = 1; j <= rows; j++)
        {
            decimal price = Math.Round((decimal)(random.NextDouble() * 100 + 1), 2);
            products.Add(new Product
            {
                ProductId = j,
                Price = price
            });
        }
        return products; 
    }

}