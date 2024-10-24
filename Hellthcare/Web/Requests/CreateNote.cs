namespace Hellthcare.Web.Requests;

public record CreateNote(
    Guid PatientId, 
    string Text
);