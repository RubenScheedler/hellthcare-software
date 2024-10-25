namespace Hellthcare.Domain.Location;

public record Reservation(DateTime From, DateTime To)
{
    public bool OverlapsWith(DateTime from, DateTime to)
    {
        // Check if the intervals overlap
        return false;
    }
}