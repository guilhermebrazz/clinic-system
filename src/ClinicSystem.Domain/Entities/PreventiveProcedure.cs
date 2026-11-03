using ClinicSystem.Domain.ValueObjects;

namespace ClinicSystem.Domain.Entities;

public class PreventiveProcedures : Procedure
{
    public int RecommendedIntervalMonths { get; set; }


    public PreventiveProcedures(string name, Enums.Specialty requiredSpecialty, Money money, int recommendedIntervalMonths) 
        :base(name, requiredSpecialty, money)
    {
        RecommendedIntervalMonths = recommendedIntervalMonths;
    }

    public override string GetCategory()
    {
        return "Preventive procedure";
    }
}