namespace Hellthcare.Core.Location.Domain;

public class LocationAggregate(
    Guid id,
    string name,
    List<Reservation> reservations)
{
    private Guid Id { get; set; } = id;
    private string Name { get; set; } = name;
    private List<Reservation> Reservations { get; } = reservations;

    public bool IsAvailable(DateTime from, DateTime to)
    {
        return !Reservations.Any(r => r.OverlapsWith(from, to));
    }

    public void Reserve(DateTime from, DateTime to)
    {
        if (!IsAvailable(from, to))
            throw new LocationAlreadyBookedException(
                $"Location already booked between {from} and {to}"
            );

        Reservations.Add(new Reservation(from, to));
    }
}