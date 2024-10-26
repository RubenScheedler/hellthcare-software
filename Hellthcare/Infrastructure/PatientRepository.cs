using Hellthcare.Application;
using Hellthcare.Application.Abstraction;
using Hellthcare.Domain;
using Hellthcare.Domain.Patient;

namespace Hellthcare.Infrastructure;

public class PatientRepository(DbContext dbContext) : IPatientRepository
{
    public PatientAggregate GetPatient(Guid id)
    {
        throw new NotImplementedException();
    }

    public List<PatientAggregate> GetPatients()
    {
        throw new NotImplementedException();
    }

    public void SavePatient(PatientAggregate patientAggregate)
    {
        throw new NotImplementedException();
    }
}