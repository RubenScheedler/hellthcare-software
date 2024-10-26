namespace Hellthcare.Core.Notification.PublicInterface;

public interface ITextSender
{
    public void SendText(string text, string patientPhoneNumber);
}