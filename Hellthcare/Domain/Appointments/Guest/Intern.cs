namespace Hellthcare.Domain.Appointments.Guest;

public class Intern : IGuest
{
    public string Name { get; set; }
    public GuestType GuestType { get; } = GuestType.Intern;
}