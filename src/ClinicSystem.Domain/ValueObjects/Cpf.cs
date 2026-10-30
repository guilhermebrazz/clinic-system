using ClinicSystem.Domain.Exceptions;

namespace ClinicSystem.Domain.ValueObjects;

public class Cpf
{
    public string Value { get; set; }   

    public Cpf(string value)
    {
        if (value.Length > 11 || value.Length < 11)
        {
            throw new InvalidCpfException("The CPF number must contain 11 digits. (Only Numbers)");
        }

        Value = value;
    }

    public string Format() // 000.000.000-00
    {
        string formatedCpf = Value.Insert(3, ".").Insert(7, ".").Insert(11, "-");
        return formatedCpf;
    }
}