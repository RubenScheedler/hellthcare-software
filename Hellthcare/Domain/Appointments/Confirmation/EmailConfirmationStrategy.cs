namespace Hellthcare.Domain.Appointments.Confirmation;

public class EmailConfirmationStrategy : IConfirmationStrategy
{
    public void Accept(IConfirmationVisitor visitor)
    {
        visitor.SendEmailConfirmation();
    }
}