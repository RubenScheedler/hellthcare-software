using Hellthcare.Domain.Enums;

namespace Hellthcare.Domain;

public class Appointment {
    public Guid Id { get; set; }
    public AppointmentType Type { get; set; }
    public Guid PatientId { get; set; }
    public DateTimeOffset From { get; set; }
    public DateTimeOffset To { get; set; }
    public Guid DoctorId { get; set; }
    // For some appointments, an intern can attend as well
    public Guid? InternId { get; set; }
    public string? Diagnosis { get; set; }
    public List<string> Prescriptions { get; set; } = [];
}