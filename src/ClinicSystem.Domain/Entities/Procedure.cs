using ClinicSystem.Domain.ValueObjects;
using ClinicSystem.Domain.Enums;
using ClinicSystem.Domain.Exceptions;


namespace ClinicSystem.Domain.Entities;

public abstract class Procedure
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public TimeSpan Duration { get; set; }
    public Specialty RequiredSpecialty { get; set; }
    public Money Money { get; set; }


    public Procedure(string name, Specialty requiredSpecialty, Money money)
    {
        Name = name;
        RequiredSpecialty = requiredSpecialty;
        Money = money;
    }

    public abstract string GetCategory();
}