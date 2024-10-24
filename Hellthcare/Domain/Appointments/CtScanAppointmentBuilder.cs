using Hellthcare.Domain.Appointments.Confirmation;
using Hellthcare.Domain.Appointments.Diagnosis;
using Hellthcare.Domain.Appointments.ReservableAssets;
using Hellthcare.Domain.Enums;

namespace Hellthcare.Domain.Appointments;

public class CtScanAppointmentBuilder : IAppointmentBuilder
{
    public AppointmentType CreateAppointmentType()
    {
        return AppointmentType.CTScan;
    }

    public IReservableAsset? CreateReservableAsset()
    {
        return new CTMachine(Guid.NewGuid());
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