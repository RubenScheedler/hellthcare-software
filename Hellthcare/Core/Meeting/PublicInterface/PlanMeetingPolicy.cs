using Hellthcare.Core.Location.PublicInterface;
using Hellthcare.Core.Meeting.Domain;
using MediatR;

namespace Hellthcare.Core.Meeting.PublicInterface;

internal class PlanMeetingPolicy(
    IMeetingRepository repository,
    ILocationService locationService,
    IMediator mediator
) : IRequestHandler<PlanMeeting>
{
    public async Task Handle(
        PlanMeeting command,
        CancellationToken cancellationToken)
    {
        // orchestration: instruct other context to perform operation
        locationService.Reserve(
            command.LocationId,
            command.From,
            command.To
        );

        var id = Guid.NewGuid();
        repository.SaveMeeting(
            new MeetingAggregate(
                id,
                command.From,
                command.To,
                command.Participants
            )
        );

        // choreography: let other contexts react on their own
        await mediator.Publish(
            new MeetingPlanned(
                id,
                command.From,
                command.To,
                command.Participants
            )
        );
    }
}