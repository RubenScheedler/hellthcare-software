
namespace Hellthcare.Domain;

public class Patient {
    private Guid Id {get; set; }
    private string Name {get; set; }
    private string PhoneNumber {get; set; }
    private string Address {get; set; }
    private List<string> Notes {get; }

    public Patient(Guid id, string name, string phoneNumber, string address) {
        Id = id;
        Name = name;
        PhoneNumber = phoneNumber;
        Address = address;
        Notes = [];
    }
}