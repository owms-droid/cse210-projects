class Order
{
    private List<Product> products;
    private Customer customer;

    public Order(Customer customer)
    {
        this.customer = customer;
        products = new List<Product>();
    }

    // Method to add a product to the order
    public void AddProduct(Product product)
    {
        products.Add(product);
    }

    // Method to calculate the total cost of the order
    public decimal GetTotalCost()
    {
        decimal totalCost = 0;

        foreach (var product in products)
        {
            totalCost += product.GetTotalCost();
        }

        // Add shipping cost
        totalCost += customer.LivesInUSA() ? 5 : 35;

        return totalCost;
    }

    // Method to get the packing label
    public string GetPackingLabel()
    {
        string label = "Packing Label:\n";
        foreach (var product in products)
        {
            label += product.GetPackingLabel() + "\n";
        }
        return label;
    }

    // Method to get the shipping label
    public string GetShippingLabel()
    {
        return $"Shipping Label:\n{customer.GetName()}\n{customer.GetAddress().GetFullAddress()}";
    }
}
