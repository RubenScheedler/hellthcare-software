using Hellthcare.Application.Abstraction;
using Hellthcare.Domain;

namespace Hellthcare.Application;

public class PatientService(
    IPatientRepository repository,
    IEmailSender emailSender
) {

    public Patient GetPatient(Guid id) => repository.GetPatient(id);

    public void CreateNote(Guid patientId, string note) {
        var patient = repository.GetPatient(patientId);
        
        patient.Notes.Add(note);

        repository.SavePatient(patient);
    }

    public void MakeAppointment(
        Guid patientId, 
        Appointment appointment
    ) {
        var patient = repository.GetPatient(patientId);

        // All scan operations are divisble by 8. The rest not.
        if ((int)appointment.Type % 8 == 0) { // 
            // Claim machine if possible
            // Find all patients. Check if any has reserved the MRI. If not, allow
            var patients = repository.GetPatients();

            foreach (var p in patients) {
                var items = patient.GetOverlappingPlanningItems(appointment.From, appointment.To);
                if (items.Any(i => i.Type == appointment.Type)) { // Machine is taken in this timeslot already!
                    throw new InvalidOperationException("Machine for appointment is not available");
                }
            }
        }

        patient.Appointments.Add(appointment);

        emailSender.SendEmail(
            "You have an appointment for: " + appointment.Type, 
            new IEmailSender.Recipient { EmailAddress = patient.EmailAddress}
        );

        repository.SavePatient(patient);
    }
}