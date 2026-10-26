namespace ClinicSystem.Domain.ValueObjects;

public class Address
{
    public string Street { get; set; }
    public string Neighborhood { get; set; }
    public string City { get; set; }

    public Address()
    {
    }

    public Address(string street, string neighborhood, string city)
    {
        Street = street;
        Neighborhood = neighborhood;
        City = city;
    }
}