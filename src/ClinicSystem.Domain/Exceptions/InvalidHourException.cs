using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClinicSystem.Domain.Exceptions
{
    public class InvalidHourException : ApplicationException
    {
        public InvalidHourException(string message) : base(message)
        {
        }
    }
}