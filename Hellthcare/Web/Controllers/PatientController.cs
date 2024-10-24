using Hellthcare.Application;
using Hellthcare.Web.Requests;
using Microsoft.AspNetCore.Mvc;

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
        patientService.MakeAppointment(
            patientId, 
            createAppointment.AppointmentType, 
            createAppointment.From, 
            createAppointment.To, 
            createAppointment.DoctorId
        );
        
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