using Hellthcare.Core.Confirmation.PublicInterface;

namespace Hellthcare.Infrastructure.Communication;

public class EmailService : IEmailSender
{
    public void SendEmail(string body, IEmailSender.Recipient recipient)
    {
        
    }
}