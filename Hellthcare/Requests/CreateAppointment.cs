namespace Hellthcare.Requests;

public record CreateAppointment(
    DateTime Date, 
    Guid PatientId, 
    Guid DoctorId
);