namespace Hellthcare.Domain.Appointments.ReservableAssets;

public class MRIMachine : IReservableAsset
{
    internal MRIMachine(Guid id)
    {
        Id = id;
    }

    public Guid Id { get; }
    public string Name { get; } = "MRI Machine";
}