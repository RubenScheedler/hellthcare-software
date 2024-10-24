using Hellthcare.Application;
using Hellthcare.Web.Requests;
using Microsoft.AspNetCore.Mvc;
using Hellthcare.Domain;

namespace Hellthcare.Web.Controllers;

[Route("api/[controller]")]
public class PatientController(PatientService patientService) : Controller
{
    [HttpGet("/patient/{patientId:guid}")]
    public IActionResult GetPatient([FromRoute] Guid patientId)
    {
        return Ok(patientService.GetPatient(patientId));
    }

    [HttpPost("/patient/{patientId:guid}/appointment")]
    public IActionResult MakeAppointment(
        [FromRoute] Guid patientId,
        [FromBody] CreateAppointment createAppointment)
    {
        var appointment = new Appointment()
        {
            PatientId = createAppointment.PatientId,
            DoctorId = createAppointment.DoctorId,
            From = createAppointment.From,
            To = createAppointment.To
        };
        patientService.MakeAppointment(patientId, appointment);
        
        return Ok();
    }

    [HttpPost("/patient/{patientId:guid}/note")]
    public IActionResult CreateNote(
        [FromRoute] Guid patientId,
        [FromBody] CreateNote createNote)
    {
        patientService.CreateNote(patientId, createNote.Text);

        return Ok();
    }
}