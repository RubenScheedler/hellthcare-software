namespace Hellthcare.Web.Requests;

public record CreateAppointment(
    DateTime From,
    DateTime To,
    Guid PatientId,
    Guid DoctorId,
    Guid LocationId
);