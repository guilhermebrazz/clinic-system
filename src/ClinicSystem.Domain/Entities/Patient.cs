using ClinicSystem.Domain.ValueObjects;

namespace ClinicSystem.Domain.Entities;

public class Patient : User
{
    public DateTime BirhtDate { get; set; }
    
    public Patient()
    {
    }

    public Patient(string name, string email, string phone, Address address, Cpf cpf, DateTime birthDate) :base(name, email, phone, address, cpf)
    {
        BirhtDate = birthDate;
    }

    public int GetAge()
    {
        DateTime d1 = DateTime.Now;
        return d1.Year - BirhtDate.Year;
    }

    public bool IsMinor()
    {
       return GetAge() < 18;
    }

    public override string GetRole()
    {
        return "Patient";
    }
}