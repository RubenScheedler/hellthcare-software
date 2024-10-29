using Hellthcare.Core.Patient.Domain;

namespace Hellthcare.Core.Patient.PublicInterface;

public interface IPatientRepository
{
    PatientAggregate GetPatient(Guid id);
    List<PatientAggregate> GetPatients();
    void SavePatient(PatientAggregate patientAggregate);
}