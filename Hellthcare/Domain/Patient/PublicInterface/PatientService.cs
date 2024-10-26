using Hellthcare.Application.Abstraction;
using Hellthcare.Domain.Patient;

namespace Domain.Patient.PublicInterface;

public class PatientService(
    IPatientRepository repository
) {

    public PatientAggregate GetPatient(Guid id) => repository.GetPatient(id);

    public void CreateNote(Guid patientId, string note) {
        var patient = repository.GetPatient(patientId);
        
        patient.MakeNote(note);

        repository.SavePatient(patient);
    }
}