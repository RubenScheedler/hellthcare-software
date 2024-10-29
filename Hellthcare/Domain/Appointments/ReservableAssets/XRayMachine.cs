namespace Hellthcare.Domain.Appointments.ReservableAssets;

public class XRayMachine : IReservableAsset
{
    internal XRayMachine(Guid id)
    {
        Id = id;
    }

    public Guid Id { get; }
    public string Name { get; } = "X-Ray Machine";
}