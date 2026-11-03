using ClinicSystem.Domain.Exceptions;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;

namespace ClinicSystem.Domain.ValueObjects
{
    public sealed class TimeSlot
    {
        public static TimeSpan Duration { get; set; } = TimeSpan.FromMinutes(30);

        public DateTime Start { get;}
        public DateTime End => Start + Duration;

        public TimeSlot(DateTime start)
        {
            if (start.Hour < 8 || start.Hour > 18)
            {
                throw new InvalidHourException("Clinic open only from 8AM to 6 PM");
            }
            if (start.Minute % 30 != 0 || start.Second != 0)
                throw new InvalidTimeException("The time must finish with :00 or :30");
            Start = start;
        }
        public bool Overlaps(TimeSlot other) // Same start
        {
            return Start == other.Start;
        }
    }
} 