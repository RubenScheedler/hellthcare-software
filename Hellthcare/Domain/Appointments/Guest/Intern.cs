namespace Hellthcare.Domain.Appointments.Guest;

public class Intern : IGuest
{
    public GuestType GuestType { get; } = GuestType.Intern;
    public string Name { get; set; }
}