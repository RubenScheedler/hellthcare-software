namespace Hellthcare.Domain.Appointments.Confirmation;

public interface IConfirmationVisitor
{
    void SendEmailConfirmation();
    void SendTextConfirmation();
}