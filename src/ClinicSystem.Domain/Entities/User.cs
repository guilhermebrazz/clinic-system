using ClinicSystem.Domain.ValueObjects;

namespace ClinicSystem.Domain.Entities;

public abstract class User
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public string Email { get; set; }
    public string Phone { get; set; }
    public Address Address { get; set; }
    public Cpf Cpf { get; set; }

    public User()
    {
    }

    public User(string name, string email, string phone, Address address, Cpf cpf)
    {
        Name = name;
        Email = email;
        Phone = phone;
        Address = address;
        Cpf = cpf;
    }

    public abstract string GetRole();
}