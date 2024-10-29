namespace Hellthcare.Domain.Appointments.ReservableAssets;

public class CTMachine : IReservableAsset
{
    internal CTMachine(Guid id)
    {
        Id = id;
    }

    public Guid Id { get; }
    public string Name { get; } = "CT Machine";
}