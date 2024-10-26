using Domain.Location.PublicInterface;
using MediatR;

namespace Domain.Meeting.PublicInterface;

internal class PlanMeetingPolicy(
    IMeetingRepository repository,
    ILocationService locationService,
    IMediator mediator
) : IRequestHandler<PlanMeetingCommand> {
    
    public async Task Handle(PlanMeetingCommand command, CancellationToken cancellationToken)
    {
        // TODO niet hier doen maar in aggr zelf?
        if (!locationService.IsAvailable(command.LocationId, command.From, command.To)) {
            return; // TODO throw exception
        }

        // orchestration: instruct other context to perform operation
        locationService.Reserve(command.LocationId, command.From, command.To); // TODO command

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
        await mediator.Publish(new MeetingPlannedEvent(id, command.From, command.To, command.Participants));
    }


}