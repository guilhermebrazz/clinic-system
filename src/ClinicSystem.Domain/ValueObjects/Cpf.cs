namespace ClinicSystem.Domain.ValueObjects;

public class Cpf
{
    public string Value { get; set; }

    public Cpf()
    {
    }

    public Cpf(string value)
    {
        Value = value;
    }
}