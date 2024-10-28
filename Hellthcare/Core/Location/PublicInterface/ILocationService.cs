namespace Hellthcare.Core.Location.PublicInterface;

public interface ILocationService {
    public bool IsAvailable(Guid locationId, DateTime from, DateTime to);
    public void Reserve(Guid locationId, DateTime from, DateTime to);
}