namespace Domain.Location;

internal class LocationRepository {
    LocationAggregate GetLocation(Guid id);
    void GetLocation(LocationAggregate location);
}