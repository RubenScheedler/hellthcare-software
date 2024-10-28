using Hellthcare.Core.Location.PublicInterface;
using Hellthcare.Core.Meeting.Domain;
using MediatR;

namespace Hellthcare.Core.Meeting.PublicInterface;

internal class PlanMeetingPolicy(
    IMeetingRepository repository,
    ILocationService locationService,
    IMediator mediator
) : IRequestHandler<PlanMeetingCommand> {
    
    public async Task Handle(PlanMeetingCommand command, CancellationToken cancellationToken)
    {
        // orchestration: instruct other context to perform operation
        locationService.Reserve(command.LocationId, command.From, command.To); 

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