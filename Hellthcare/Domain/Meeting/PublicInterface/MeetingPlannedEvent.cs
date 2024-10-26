using MediatR;

namespace Domain.Meeting.PublicInterface;

public record MeetingPlannedEvent(
    Guid Id,
    DateTime From,
    DateTime To,
    List<Participant> Participants
) : INotification;