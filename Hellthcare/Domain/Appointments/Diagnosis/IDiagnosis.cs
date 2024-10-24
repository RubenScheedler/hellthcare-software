namespace Hellthcare.Domain.Appointments.Diagnosis;

public interface IDiagnosis
{
    string Problem { get; }
    List<string> Prescriptions { get; }
}