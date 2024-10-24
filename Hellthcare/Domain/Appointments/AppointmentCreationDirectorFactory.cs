using Hellthcare.Domain.Enums;

namespace Hellthcare.Domain.Appointments;

public class AppointmentCreationDirectorFactory
{
    public static AppointmentCreationDirector CreateDirector(AppointmentType appointmentType)
    {
        return new AppointmentCreationDirector(appointmentType switch
        {
            AppointmentType.Default => new DefaultAppointmentBuilder(),
            AppointmentType.CheckUp => new CheckUpAppointmentBuilder(),
            AppointmentType.Vaccination => new VaccinationAppointmentBuilder(),
            AppointmentType.Surgery => new SurgeryAppointmentBuilder(),
            AppointmentType.MRIScan => new MriScanAppointmentBuilder(),
            AppointmentType.XRayScan => new XRayScanAppointmentBuilder(),
            AppointmentType.CTScan => new CtScanAppointmentBuilder(),
            _ => throw new ArgumentOutOfRangeException(
                nameof(appointmentType), appointmentType, "Unsupported type of appointment")
        });
    }
}