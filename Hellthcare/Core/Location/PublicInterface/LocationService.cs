namespace Hellthcare.Core.Location.PublicInterface;

class LocationService(ILocationRepository repository) : ILocationService {

    public bool IsAvailable(Guid locationId, DateTime from, DateTime to) {
        var location = repository.GetLocation(locationId);
        return location.IsAvailable(from, to);
    }

    public void Reserve(Guid locationId, DateTime from, DateTime to) {
        var location = repository.GetLocation(locationId);
        location.Reserve(from, to);
        repository.SaveLocation(location);
    }
}