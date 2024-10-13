namespace Hellthcare.Domain.Enums;

public enum AppointmentType {
    Default = 0, // BAD: Programmer wants default, but what is this really?
    CheckUp = 1,
    Vaccination = 2,
    Surgery = 4,

    // BAD: These three are also about reservation of assets. Different context, not a type of appointment?
    MRIScan = 8,
    XRayScan = 16,
    CTScan = 32
}