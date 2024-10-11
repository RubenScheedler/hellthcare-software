using Hellthcare.Application.Abstraction;
using Hellthcare.Domain;

namespace Hellthcare.Application;

public class PatientService(IPatientRepository repository) {

    public Patient GetPatient(Guid id) => repository.GetPatient(id);
}