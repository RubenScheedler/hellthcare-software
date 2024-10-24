namespace Hellthcare.Domain.Appointments.Confirmation;

public interface IConfirmationStrategy
{
    void Accept(IConfirmationVisitor visitor);
}