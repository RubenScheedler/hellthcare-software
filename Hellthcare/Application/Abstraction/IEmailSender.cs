
namespace Hellthcare.Application.Abstraction;

public interface IEmailSender {
    public void SendEmail(string body, Recipient recipient);

    public class Recipient {
        public required string EmailAddress {get; set; }
    }
}