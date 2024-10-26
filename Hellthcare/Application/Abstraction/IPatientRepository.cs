using Hellthcare.Domain.Patient;

namespace Hellthcare.Application.Abstraction;

public interface IPatientRepository {
    PatientAggregate GetPatient(Guid id);
    List<PatientAggregate> GetPatients();
    void SavePatient(PatientAggregate patientAggregate);
}