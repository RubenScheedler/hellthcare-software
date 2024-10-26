using Hellthcare.Core.Meeting.Domain;
using Hellthcare.Core.Meeting.PublicInterface;

namespace Hellthcare.Infrastructure.Persistance;

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