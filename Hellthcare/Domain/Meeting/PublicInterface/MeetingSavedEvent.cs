using SharedKernel;

namespace Domain.Meeting.PublicInterface;

public record MeetingSavedEvent(
    Guid Id,
    DateTime From,
    DateTime To,
    List<Participant> Participants
) : IEvent;