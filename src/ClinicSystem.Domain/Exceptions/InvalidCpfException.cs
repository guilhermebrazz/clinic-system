namespace ClinicSystem.Domain.Exceptions;

public class InvalidCpfException : ApplicationException
{
    public InvalidCpfException (string message) : base(message)
    {
        
    }
}