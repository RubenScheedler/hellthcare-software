
namespace Hellthcare.Core.Patient.Domain;

public class PatientAggregate {
    private Guid Id { get; set; }
    private string Name { get; set; }
    private string PhoneNumber { get; set; }
    private string EmailAddress { get; set; }
    private string Address { get; set; }
    private List<string> Notes { get; }
    private List<string> Diagnoses { get; set; } = [];
    private List<string> Prescriptions { get; set; } = [];

    public PatientAggregate(Guid id, string name, string phoneNumber, string address) {
        Id = id;
        Name = name;
        PhoneNumber = phoneNumber;
        Address = address;
        Notes = [];
    }

    internal void MakeNote(string note)
    {
        Notes.Add(note);
    }
    
    internal void DiagnoseWith(string diagnonis)
    {
        Diagnoses.Add(diagnonis);
    }

    internal void Prescribe(string prescription)
    {
        Prescriptions.Add(prescription);
    }
}