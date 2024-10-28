using Hellthcare.Core.Patient.Domain;
using Hellthcare.Core.Patient.PublicInterface;

namespace Hellthcare.Infrastructure.Persistance;

public class PatientRepository : IPatientRepository
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