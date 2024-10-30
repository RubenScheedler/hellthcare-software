using Hellthcare.Core.Meeting.Domain;
using MediatR;

namespace Hellthcare.Core.Meeting.PublicInterface;

public record MeetingPlanned(
    Guid Id,
    DateTime From,
    DateTime To,
    List<Participant> Participants
) : INotification;