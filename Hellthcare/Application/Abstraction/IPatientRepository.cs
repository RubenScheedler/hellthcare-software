using Hellthcare.Domain;

namespace Hellthcare.Application.Abstraction;

public interface IPatientRepository {
    Patient GetPatient(Guid id);
    List<Patient> GetPatients();
    void SavePatient(Patient patient);
}