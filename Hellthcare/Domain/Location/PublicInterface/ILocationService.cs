namespace Location.PublicInterface;

public interface ILocationService {
    public bool IsAvailable(Guid LocationId);
    public void Reserve(Guid LocationId, DateTime From, DateTime To);
}