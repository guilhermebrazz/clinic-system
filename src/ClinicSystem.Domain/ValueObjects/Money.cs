using ClinicSystem.Domain.Exceptions;

namespace ClinicSystem.Domain.ValueObjects;

public class Money
{
    public double Amount { get; set; }

    public Money(double amount)
    {
        if(amount < 0.0)
        {
            throw new InvalidAmountException("Insert a not negative amount.");
        }
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
