using Hellthcare.Application.Abstraction;

namespace Hellthcare.Application;

public class EmailService : IEmailSender
{
    public void SendEmail(string body, IEmailSender.Recipient recipient)
    {
        
    }
}