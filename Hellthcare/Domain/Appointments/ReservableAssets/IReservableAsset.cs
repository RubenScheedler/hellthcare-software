namespace Hellthcare.Domain.Appointments.ReservableAssets;

public interface IReservableAsset
{
    Guid Id { get; }
    string Name { get; }
}