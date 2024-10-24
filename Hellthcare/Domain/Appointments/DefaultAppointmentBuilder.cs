using Hellthcare.Domain.Appointments.Confirmation;
using Hellthcare.Domain.Appointments.Diagnosis;
using Hellthcare.Domain.Appointments.ReservableAssets;
using Hellthcare.Domain.Enums;

namespace Hellthcare.Domain.Appointments;

public class DefaultAppointmentBuilder : IAppointmentBuilder
{
    public AppointmentType CreateAppointmentType()
    {
        return AppointmentType.Default;
    }

    public IReservableAsset? CreateReservableAsset()
    {
        return null;
    }

    public IDiagnosis? CreateDiagnosis()
    {
        return null;
    }
    
    public IConfirmationStrategy CreateConfirmationStrategy()
    {
        return new EmailAndTextConfirmationStrategy();
    }
}