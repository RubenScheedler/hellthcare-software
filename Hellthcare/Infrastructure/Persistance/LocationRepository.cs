using Hellthcare.Core.Location.Domain;
using Hellthcare.Core.Location.PublicInterface;

namespace Hellthcare.Infrastructure.Persistance;

internal class LocationRepository : ILocationRepository
{
    public LocationAggregate GetLocation(Guid id)
    {
        return new LocationAggregate(id, "MRI Room", []);
    }

    public void SaveLocation(LocationAggregate location)
    {
    }
}