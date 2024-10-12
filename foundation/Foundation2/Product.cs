class Product
{
    private string name;
    private string productId;
    private decimal price;
    private int quantity;

    public Product(string name, string productId, decimal price, int quantity)
    {
        this.name = name;
        this.productId = productId;
        this.price = price;
        this.quantity = quantity;
    }

    // Method to get the total cost of the product
    public decimal GetTotalCost()
    {
        return price * quantity;
    }

    // Method to get the product name and ID for the packing label
    public string GetPackingLabel()
    {
        return $"{name} (ID: {productId})";
    }
}
