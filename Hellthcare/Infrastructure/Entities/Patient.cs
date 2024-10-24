namespace Hellthcare.Infrastructure.Entities;

public class Patient
{
    public Guid Id { get; set; }

    public string FirstName { get; set; }

    public string LastName { get; set; }
    
    public string Email { get; set; }
    public List<Note> Notes { get; set; } = [];

    public record Note(
        string Text,
        DateTime Created
    );
}