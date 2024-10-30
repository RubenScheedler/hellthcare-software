using Hellthcare.Core.Meeting.PublicInterface;
using MediatR;

namespace Hellthcare.Core.Confirmation;

public class SendMeetingConfirmationPolicy : INotificationHandler<MeetingPlanned>
{
    public Task Handle(
        MeetingPlanned meetingPlanned,
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