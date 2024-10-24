using Hellthcare.Domain.Appointments.Confirmation;
using Hellthcare.Domain.Appointments.Diagnosis;
using Hellthcare.Domain.Appointments.ReservableAssets;
using Hellthcare.Domain.Enums;

namespace Hellthcare.Domain.Appointments;

public interface IAppointmentBuilder
{
    public AppointmentType CreateAppointmentType();

    public IReservableAsset? CreateReservableAsset();

    public IDiagnosis? CreateDiagnosis();

    public IConfirmationStrategy CreateConfirmationStrategy();
}