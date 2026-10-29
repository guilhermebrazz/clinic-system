namespace ClinicSystem.Domain.Exceptions;

public class InvalidAmountException : ApplicationException
{
    public InvalidAmountException(string message) : base(message)
    {
    }
}