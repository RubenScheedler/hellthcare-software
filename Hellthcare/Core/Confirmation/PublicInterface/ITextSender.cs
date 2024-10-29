namespace Hellthcare.Core.Confirmation.PublicInterface;

public interface ITextSender
{
    public void SendText(
        string text,
        string patientPhoneNumber);
}