namespace ClinicSystem.Domain.Exceptions;

public class InvalidDurationException : ApplicationException
{
    public InvalidDurationException(string message) :base(message)
    {
    }
    
}