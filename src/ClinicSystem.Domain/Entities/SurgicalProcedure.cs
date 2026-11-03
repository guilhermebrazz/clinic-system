using ClinicSystem.Domain.ValueObjects;

namespace ClinicSystem.Domain.Entities;

public class SurgicalProcedure : Procedure
{
    public int RecoveryDays { get; set; }   

    public SurgicalProcedure(string name, Enums.Specialty requiredSpecialty, Money money, int recoveryDays) 
        :base(name, requiredSpecialty, money)
    {
        RecoveryDays = recoveryDays;
    }

    public override string GetCategory()
    {
        return "Surgical procedure";
    }
}