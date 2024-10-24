namespace Hellthcare.Domain.Appointments.Confirmation;

public class TextConfirmationStrategy : IConfirmationStrategy
{
    public void Accept(IConfirmationVisitor visitor)
    {
        visitor.SendTextConfirmation();
    }
}