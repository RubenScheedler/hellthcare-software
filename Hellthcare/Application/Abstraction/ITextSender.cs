namespace Hellthcare.Application.Abstraction;

public interface ITextSender
{
    public void SendText(string text, string patientPhoneNumber);
}