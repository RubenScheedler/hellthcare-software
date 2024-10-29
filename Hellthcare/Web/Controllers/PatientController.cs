using Hellthcare.Core.Meeting.Domain;
using Hellthcare.Core.Meeting.PublicInterface;
using Hellthcare.Core.Patient.PublicInterface;
using Hellthcare.Web.Requests;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Hellthcare.Web.Controllers;

public class PatientController(PatientService patientService, IMediator mediator) : Controller
{
    [HttpGet("/patient/{patientId:guid}")]
    public IActionResult GetPatient([FromRoute] Guid patientId)
    {
        return Ok(
            patientService.GetPatient(patientId)
        );
    }

    [HttpPost("/patient/{patientId:guid}/appointment")]
    public IActionResult MakeAppointment(
        [FromRoute] Guid patientId,
        [FromBody] CreateAppointment createAppointment)
    {
        mediator.Send(new PlanMeetingCommand(
                createAppointment.From,
                createAppointment.To,
                createAppointment.LocationId,
                [
                    new Participant(createAppointment.PatientId),
                    new Participant(createAppointment.DoctorId)
                ]
            )
        );

        return Ok();
    }

    [HttpPost("/patient/{patientId:guid}/note")]
    public IActionResult CreateNote(
        [FromRoute] Guid patientId,
        [FromBody] CreateNote createNote)
    {
        patientService.CreateNote(
            patientId,
            createNote.Text
        );

        return Ok();
    }
}