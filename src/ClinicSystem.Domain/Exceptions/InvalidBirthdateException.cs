namespace ClinicSystem.Domain.Exceptions;

public class InvalidBirhdateException : ApplicationException
{
    public InvalidBirhdateException(string message) :base(message)
    {
    }
    
}