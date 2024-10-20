namespace Hellthcare.Requests;

public record CreateNote(
    Guid PatientId, 
    string Text
);