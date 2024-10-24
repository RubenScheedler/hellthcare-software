using Hellthcare.Application.Abstraction;

namespace Hellthcare.Domain.Appointments.Confirmation;

public class ConfirmationVisitor(IEmailSender emailSender, ITextSender textSender, string text, Patient patient) : IConfirmationVisitor
{
    public void SendEmailConfirmation()
    {
        emailSender.SendEmail(
            text, 
            new IEmailSender.Recipient { EmailAddress = patient.EmailAddress}
        );
    }

    public void SendTextConfirmation()
    {
        textSender.SendText(text, patient.PhoneNumber);
    }
}