namespace ClinicSystem.Domain.Exceptions
{
    public class InvalidEmailException : ApplicationException
    {
        public InvalidEmailException(string message) : base(message)
        {
        }
    }
}