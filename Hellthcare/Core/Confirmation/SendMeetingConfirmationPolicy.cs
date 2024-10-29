using Hellthcare.Core.Meeting.PublicInterface;
using MediatR;

namespace Hellthcare.Core.Confirmation;

public class SendMeetingConfirmationPolicy : INotificationHandler<MeetingPlannedEvent>
{
    public Task Handle(
        MeetingPlannedEvent meetingPlanned,
        CancellationToken cancellationToken)
    {
        meetingPlanned.Participants.ForEach(participant =>
            {
                // TODO send email and text to all
            }
        );

        return Task.CompletedTask;
    }
}