namespace Hellthcare.Domain.Enums;

public enum AppointmentType
{
    Default = 0,
    CheckUp = 1,
    Vaccination = 2,
    Surgery = 4,
    MRIScan = 8,
    XRayScan = 16,
    CTScan = 32
}