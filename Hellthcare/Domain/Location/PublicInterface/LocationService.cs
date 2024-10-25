namespace Domain.Location.PublicInterface;

public class LocationService(LocationRepository repository) : ILocationService {

    public bool IsAvailable(Guid locationId, DateTimeOffset from, DateTimeOffset to) {
        var location = repository.GetLocation(locationId);
        return location.IsAvailable(from, to);
    }

    public void Reserve(Guid locationId, DateTime from, DateTime to) {
        var location = repository.GetLocation(locationId);
        location.Reserve(from, to);
        repository.SaveLocation(location);
    }
}