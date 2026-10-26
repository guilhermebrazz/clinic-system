namespace ClinicSystem.Domain.ValueObjects;

public class Money
{
    public double Amount { get; set; }

    public Money(double amount)
    {
        Amount = amount;
    }

    public void Add(double qtd)
    {
        Amount += qtd;
    }

    public void Subtract(double qtd)
    {
        Amount -= qtd;
    }

    public void Multiply(double qtd)
    {
        Amount *= qtd;
    }
}
