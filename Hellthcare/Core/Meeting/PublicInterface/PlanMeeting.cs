using Hellthcare.Core.Meeting.Domain;
using MediatR;

namespace Hellthcare.Core.Meeting.PublicInterface;

public record PlanMeeting(
    DateTime From,
    DateTime To,
    Guid LocationId,
    List<Participant> Participants
) : IRequest;