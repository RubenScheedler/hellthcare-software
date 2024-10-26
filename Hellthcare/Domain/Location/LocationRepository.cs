using Hellthcare.Domain.Location;

namespace Domain.Location;

internal class LocationRepository : ILocationRepository {
    public LocationAggregate GetLocation(Guid id)
    {
        return new LocationAggregate(id, "MRI Room", []);
    }

    public void SaveLocation(LocationAggregate location)
    {

    }
}