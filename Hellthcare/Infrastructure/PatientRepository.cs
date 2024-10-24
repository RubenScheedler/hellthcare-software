using Hellthcare.Application;
using Hellthcare.Application.Abstraction;
using Hellthcare.Domain;

namespace Hellthcare.Infrastructure;

public class PatientRepository(DbContext dbContext) : IPatientRepository
{
    public Patient GetPatient(Guid id)
    {
        throw new NotImplementedException();
    }

    public List<Patient> GetPatients()
    {
        throw new NotImplementedException();
    }

    public void SavePatient(Patient patient)
    {
        throw new NotImplementedException();
    }
}