using Hellthcare.Application;
using Hellthcare.Entities;
using Hellthcare.Requests;
using Microsoft.AspNetCore.Mvc;

namespace Hellthcare.Controllers;

[Route("api/[controller]")]
public class PatientController(
    DbContext dbContext,
    EmailService emailService) : Controller
{
    [HttpGet("/patient/{patientId:guid}")]
    public IActionResult GetPatient([FromRoute] Guid patientId)
    {
        var patients = dbContext.GetPatients();
        foreach (var patient in patients)
        {
            if (patient.Id == patientId)
            {
                return Ok(patient);
            }
        }

        throw new Exception("Patient not found");
    }

    [HttpPost("/patient/{patientId:guid}/appointment")]
    public IActionResult MakeAppointment(
        [FromRoute] Guid patientId,
        [FromBody] CreateAppointment createAppointment)
    {
        var patients = dbContext.GetPatients();
        var patient = patients.FirstOrDefault(p => p.Id == patientId);

        var doctors = dbContext.GetDoctors();
        var doctor = doctors.FirstOrDefault(p => p.Id == createAppointment.DoctorId);

        var appointment = new Appointment();
        appointment.PatientId = patientId;
        appointment.Date = createAppointment.Date;
        appointment.DoctorId = createAppointment.DoctorId;

        emailService.SendEmail(
            patient.Email,
            "appointment created",
            $"Your have an appointment with doctor {doctor.LastName} at {appointment.Date}.");

        dbContext.Save(appointment);

        return Ok();
    }

    [HttpPost("/patient/{patientId:guid}/note")]
    public IActionResult CreateNote(
        [FromRoute] Guid patientId,
        [FromBody] CreateNote createNote)
    {
        var patients = dbContext.GetPatients();
        var patient = patients.FirstOrDefault(p => p.Id == patientId);

        patient.Notes.Add(
            new Patient.Note(
                createNote.Text, 
                DateTime.Now));

        dbContext.Save(patient);

        return Ok();
    }
}