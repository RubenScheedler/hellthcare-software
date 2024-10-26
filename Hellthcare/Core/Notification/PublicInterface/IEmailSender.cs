
namespace Hellthcare.Core.Notification.PublicInterface;

public interface IEmailSender {
    public void SendEmail(string body, Recipient recipient);

    public class Recipient {
        public required string EmailAddress {get; set; }
    }
}