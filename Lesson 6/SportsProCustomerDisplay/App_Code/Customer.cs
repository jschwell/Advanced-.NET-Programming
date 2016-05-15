public class Customer
{
    public string CustomerID { get; set; }
    public string Name { get; set; }
    public string Address { get; set; }
    public string City { get; set; }
    public string State { get; set; }
    public string ZipCode { get; set; }
    public string Phone { get; set; }
    public string Email { get; set; }

    public string AddressDisplay()
    {
        string displayString = string.Format("{0}, {1} {2}",
            City, State, ZipCode);
        return displayString;
    }

    public string ContactDisplay()
    {
        string displayString = string.Format("{0}: {1}; {2}",
            Name, Phone, Email);

        return displayString;
    }
}