using Hellthcare.Domain.Appointments.Guest;

namespace Hellthcare.Domain.Appointments;

public class AppointmentCreationDirector(IAppointmentBuilder builder)
{

    public Appointment CreateAppointment(
        Guid patientId, 
        DateTimeOffset from, 
        DateTimeOffset to,
        Guid doctorId,
        List<IGuest> guests
    )
    {
        return new Appointment(
            Guid.NewGuid(),
            builder.CreateAppointmentType(),
            patientId,
            from,
            to,
            doctorId,
            builder.CreateReservableAsset(),
            builder.CreateDiagnosis(),
            guests,
            builder.CreateConfirmationStrategy()
        );
    }
}