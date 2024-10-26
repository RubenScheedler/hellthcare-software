using Domain.Meeting.PublicInterface;
using MediatR;
namespace Hellthcare.Domain.Notification;

public class SendMeetingNotificationPolicy : INotificationHandler<MeetingPlannedEvent>
{
    public Task Handle(MeetingPlannedEvent meetingPlanned, CancellationToken cancellationToken)
    {
        meetingPlanned.Participants.ForEach(participant =>
            {
                // TODO send email and text to all
            }
        );
        
        return Task.CompletedTask;
    }
}