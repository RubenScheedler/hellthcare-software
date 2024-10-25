using Domain.Meeting.PublicInterface;
using SharedKernel;

namespace Hellthcare.Domain.Notification;

public class SendMeetingNotificationPolicy : IHandleMessages<MeetingPlannedEvent>
{
    public void HandleMessage(MeetingPlannedEvent message)
    {
        message.Participants.ForEach(participant =>
            {
                // TODO send email and text to all
            }
        );
    }
}