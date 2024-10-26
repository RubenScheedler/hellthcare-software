namespace Hellthcare.Domain.Location;

internal interface ILocationRepository
{
    internal LocationAggregate GetLocation(Guid id);
    internal void SaveLocation(LocationAggregate location);
}