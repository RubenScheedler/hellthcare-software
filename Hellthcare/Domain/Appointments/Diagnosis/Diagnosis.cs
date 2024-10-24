namespace Hellthcare.Domain.Appointments.Diagnosis;

public class Diagnosis : IDiagnosis
{
    public string Problem { get; }
    public List<string> Prescriptions { get; }
}