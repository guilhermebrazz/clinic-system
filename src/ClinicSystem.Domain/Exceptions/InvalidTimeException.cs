using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClinicSystem.Domain.Exceptions
{
    public class InvalidTimeException: ApplicationException
    {
        public InvalidTimeException(string message) : base(message)
        {
        }
    }
}