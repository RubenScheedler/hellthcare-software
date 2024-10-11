using Hellthcare.Domain;

namespace Hellthcare.Application.Abstraction;

public interface IPatientRepository {
    Patient GetPatient(Guid id);
    void SavePatient(Patient patient);
}