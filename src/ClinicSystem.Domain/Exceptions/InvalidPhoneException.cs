namespace ClinicSystem.Domain.Exceptions
{
    public class InvalidPhoneException : ApplicationException
    {
        public InvalidPhoneException(string message) : base(message)
        {
        }
    }
}