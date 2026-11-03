using ClinicSystem.Domain.Enums;
using ClinicSystem.Domain.ValueObjects;

namespace ClinicSystem.Domain.Entities;

public class Appointment
{
    public Guid Id { get; set; }
    public Dentist Dentist { get; set; }
    public Patient Patient { get; set; }
    public List<Procedure> Procedures { get; set; } = new List<Procedure>();
    public AppointmentStatus Status { get; set; }
    public TimeSlot TimeSlot { get; set; }

    
    public Appointment(Dentist dentist, Patient patient, AppointmentStatus status, TimeSlot timeSlot)
    {
        Dentist = dentist;
        Patient = patient;
        Status = status;
        TimeSlot = timeSlot;
    }

    public void AddProcedure(Procedure procedure)
    {
        Procedures.Add(procedure);
    }

    public void RemoveProcedure(Procedure procedure)
    {
        Procedures.Remove(procedure);
    }

    public double CalculateTotal()
    {   
        double sum = 0.0;

        foreach (Procedure procedure in Procedures)
        {
            sum += procedure.Money.Amount;
        }

        return sum;
    }
    public void Confirm()
    {
        ChangeStatus(AppointmentStatus.Confirmed);
    }

    public void Cancel()
    {
        ChangeStatus(AppointmentStatus.Canceled);
    }
    public void Complete()
    {
        ChangeStatus(AppointmentStatus.Confirmed);
    }
    public void ChangeStatus(AppointmentStatus newStatus)
    {
        Status = newStatus;
    }
}