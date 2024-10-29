using Hellthcare.Core.Meeting.Domain;
using MediatR;

namespace Hellthcare.Core.Meeting.PublicInterface;

public record PlanMeetingCommand(
    DateTime From,
    DateTime To,
    Guid LocationId,
    List<Participant> Participants
) : IRequest;