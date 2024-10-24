using Hellthcare.Domain.Appointments.Confirmation;
using Hellthcare.Domain.Appointments.Diagnosis;
using Hellthcare.Domain.Appointments.ReservableAssets;
using Hellthcare.Domain.Enums;

namespace Hellthcare.Domain.Appointments;

public class XRayScanAppointmentBuilder : IAppointmentBuilder
{
    public AppointmentType CreateAppointmentType()
    {
        return AppointmentType.XRayScan;
    }

    public IReservableAsset? CreateReservableAsset()
    {
        return new XRayMachine(Guid.NewGuid());
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