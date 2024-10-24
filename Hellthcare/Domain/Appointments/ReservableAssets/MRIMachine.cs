namespace Hellthcare.Domain.Appointments.ReservableAssets;

public class MRIMachine : IReservableAsset
{
    public Guid Id { get; }
    public string Name { get; } = "MRI Machine";

    internal MRIMachine(Guid id)
    {
        Id = id;
    }
}