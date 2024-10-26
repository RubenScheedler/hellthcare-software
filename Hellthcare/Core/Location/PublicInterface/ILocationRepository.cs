using Hellthcare.Core.Location.Domain;

namespace Hellthcare.Core.Location.PublicInterface;

internal interface ILocationRepository
{
    internal LocationAggregate GetLocation(Guid id);
    internal void SaveLocation(LocationAggregate location);
}