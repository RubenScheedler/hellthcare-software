using Hellthcare.Domain.Appointments.Confirmation;
using Hellthcare.Domain.Appointments.Diagnosis;
using Hellthcare.Domain.Appointments.Guest;
using Hellthcare.Domain.Appointments.ReservableAssets;
using Hellthcare.Domain.Enums;

namespace Hellthcare.Domain.Appointments;

public sealed class Appointment {
    public Guid Id { get; set; }
    public AppointmentType Type { get; set; }
    public Guid PatientId { get; set; }
    public DateTimeOffset From { get; set; }
    public DateTimeOffset To { get; set; }
    public Guid DoctorId { get; set; }
    
    public IReservableAsset? ReservableAsset { get; }
    public IDiagnosis? Diagnosis { get; }
    public List<IGuest> Guests { get; }
    public IConfirmationStrategy ConfirmationStrategy { get; }

    internal Appointment(
        Guid id,
        AppointmentType type,
        Guid patientId,
        DateTimeOffset from,
        DateTimeOffset to,
        Guid doctorId,
        IReservableAsset? reservableAsset,
        IDiagnosis? diagnosis,
        List<IGuest> guests,
        IConfirmationStrategy confirmationStrategy
    )
    {
        Id = id;
        Type = type;
        PatientId = patientId;
        From = from;
        To = to;
        DoctorId = doctorId;
        ReservableAsset = reservableAsset;
        Diagnosis = diagnosis;
        Guests = guests;
        ConfirmationStrategy = confirmationStrategy;
    }
}