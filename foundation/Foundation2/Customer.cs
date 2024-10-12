class Customer
{
    private string name;
    private Address address;

    public Customer(string name, Address address)
    {
        this.name = name;
        this.address = address;
    }

    // Method to check if the customer lives in the USA
    public bool LivesInUSA()
    {
        return address.IsInUSA();
    }

    // Method to get the name of the customer
    public string GetName()
    {
        return name;
    }

    // Method to get the address of the customer
    public Address GetAddress()
    {
        return address;
    }
}