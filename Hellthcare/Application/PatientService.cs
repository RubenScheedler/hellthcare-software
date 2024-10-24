using Hellthcare.Application.Abstraction;
using Hellthcare.Domain;
using Hellthcare.Domain.Appointments;
using Hellthcare.Domain.Appointments.Confirmation;
using Hellthcare.Domain.Enums;

namespace Hellthcare.Application;

public class PatientService(
    IPatientRepository repository,
    IEmailSender emailSender,
    ITextSender textSender
) {

    public Patient GetPatient(Guid id) => repository.GetPatient(id);

    public void CreateNote(Guid patientId, string note) {
        var patient = repository.GetPatient(patientId);
        
        patient.Notes.Add(note);

        repository.SavePatient(patient);
    }

    public void MakeAppointment(
        Guid patientId, 
        AppointmentType appointmentType, 
        DateTimeOffset from, 
        DateTimeOffset to,
        Guid doctorId
    ) {
        var patient = repository.GetPatient(patientId);

        var director = AppointmentCreationDirectorFactory.CreateDirector(appointmentType);
        
        var newAppointment = director.CreateAppointment(patientId, from, to, doctorId, []);

        CheckReservableAsset(newAppointment, patient);
        
        patient.Appointments.Add(newAppointment);
        
        IConfirmationVisitor visitor = new ConfirmationVisitor(emailSender, textSender, "You have an appointment!", patient);
        
        newAppointment.ConfirmationStrategy.Accept(visitor);

        repository.SavePatient(patient);
    }

    private void CheckReservableAsset(Appointment newAppointment, Patient patient)
    {
        if (newAppointment.ReservableAsset != null) { // 
            // Claim machine if possible
            // Find all patients. Check if any has reserved the asset. If not, allow
            var patients = repository.GetPatients();

            foreach (var p in patients) {
                var items = patient.GetOverlappingPlanningItems(newAppointment.From, newAppointment.To);
                if (items.Any(i => newAppointment.ReservableAsset.Equals(i.ReservableAsset))) { // Machine is taken in this timeslot already!
                    throw new InvalidOperationException("Machine for appointment is not available");
                }
            }
        }
    }
}