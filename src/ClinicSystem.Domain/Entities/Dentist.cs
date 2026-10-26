using ClinicSystem.Domain.ValueObjects;
using ClinicSystem.Domain.Enums;
using System.Security.Cryptography.X509Certificates;

namespace ClinicSystem.Domain.Entities;

public class Dentist : User
{
    public List<Specialty> Specialties { get; set; } = new List<Specialty>();

    public Dentist()
    {
    }

    public Dentist(string name, string email, string phone, Address address, Cpf cpf) :base(name, email, phone, address, cpf)
    {
    }

    public void AddSpecialty(Specialty specialty)
    {
        Specialties.Add(specialty);
    }

    public bool CanPerform(Procedure procedure)
    {
        int x = 0;

        foreach (Specialty specialty in Specialties)
        {
            if (specialty == procedure.RequiredSpecialty)
            {
                x += 1;
            } 
        }

        return x >= 1;
    }

    public override string GetRole()
    {
        return "Dentist";
    }
}