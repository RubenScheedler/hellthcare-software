namespace Hellthcare.Domain.Appointments.ReservableAssets;

public class CTMachine : IReservableAsset
{
    public Guid Id { get; }
    public string Name { get; } = "CT Machine";
    
    internal CTMachine(Guid id)
    {
        Id = id;
    }
}