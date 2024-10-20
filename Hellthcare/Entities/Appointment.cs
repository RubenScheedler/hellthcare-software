namespace Hellthcare.Entities;

public class Appointment
{
    public Guid PatientId { get; set; }

    public Guid DoctorId { get; set; }
    
    public DateTime Date { get; set; }
}