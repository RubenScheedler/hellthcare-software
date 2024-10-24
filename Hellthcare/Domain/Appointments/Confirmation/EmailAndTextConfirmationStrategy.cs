namespace Hellthcare.Domain.Appointments.Confirmation;

public class EmailAndTextConfirmationStrategy : IConfirmationStrategy
{
    public void Accept(IConfirmationVisitor visitor)
    {
        visitor.SendEmailConfirmation();
        visitor.SendTextConfirmation();
    }
}