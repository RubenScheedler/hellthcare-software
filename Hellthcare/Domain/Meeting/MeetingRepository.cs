using Domain.Meeting;

namespace Hellthcare.Domain.Meeting;

internal class MeetingRepository : IMeetingRepository
{
    public MeetingAggregate GetMeeting(Guid id)
    {
        return new MeetingAggregate(id, DateTime.Now.AddHours(-1), DateTime.Now, []);
    }

    public void SaveMeeting(MeetingAggregate meeting)
    {
    }
}