using ClinicSystem.Domain.ValueObjects;
using ClinicSystem.Domain.Enums;

namespace ClinicSystem.Domain.Entities;

public class Appointment
{
    public Guid Id { get; set; }
    public List<Procedure> Procedures { get; set; }
    public AppointmentStatus Status { get; set; }
    public TimeSLot TimeSlot { get; set; }
}