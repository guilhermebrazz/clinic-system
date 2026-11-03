using ClinicSystem.Domain.Exceptions;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClinicSystem.Domain.ValueObjects
{
    public class Phone
    {
        public string Value { get; set; }
        
        public Phone(string value)
        {   
            if(string.IsNullOrWhiteSpace(value) || value.Length != 11 || value.All(char.IsDigit) == false)
            {
                throw new InvalidPhoneException("The phone must contain only numbers and 11 digits Ex: 79912345678.");
            }
            Value = Format(value);
        }
        //(79)99612-7874
        public string Format(string value)
        {
            return value.Insert(0, "(").Insert(3, ")").Insert(4, " ").Insert(10, "-");
        }
    }
}