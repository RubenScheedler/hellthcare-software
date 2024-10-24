namespace Hellthcare.Domain.Appointments.ReservableAssets;

public class XRayMachine : IReservableAsset
{
    public Guid Id { get; }
    public string Name { get; } = "X-Ray Machine";
    
    internal XRayMachine(Guid id)
    {
        Id = id;
    }
}