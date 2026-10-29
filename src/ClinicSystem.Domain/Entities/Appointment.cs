using ClinicSystem.Domain.ValueObjects;
using ClinicSystem.Domain.Enums;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;

namespace ClinicSystem.Domain.Entities;

public class Appointment
{
    public Guid Id { get; set; }
    public List<Procedure> Procedures { get; set; } = new List<Procedure>();
    public AppointmentStatus Status { get; set; }
    public TimeSpan TimeSlot { get; set; } = TimeSpan.FromMinutes(30);

    
    public Appointment(AppointmentStatus status)
    {
        Status = status;
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