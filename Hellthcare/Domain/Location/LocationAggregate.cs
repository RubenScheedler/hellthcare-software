namespace Hellthcare.Domain.Location;

public class LocationAggregate
{
    private Guid Id { get; set; }
    private string Name { get; set; }
    private List<Reservation> Reservations { get; set; }
    
    public bool IsAvailable(DateTime from, DateTime to)
    {
        return !Reservations.Any(r => r.OverlapsWith(from, to));
    }

    public void Reserve(DateTime from, DateTime to)
    {
        if (!IsAvailable(from, to))
        {
            throw new LocationAlreadyBookedException($"Location already booked between {from} and {to}");
        }
        Reservations.Add(new Reservation(from, to));
    }
}