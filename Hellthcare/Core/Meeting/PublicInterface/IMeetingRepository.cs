using Hellthcare.Core.Meeting.Domain;

namespace Hellthcare.Core.Meeting.PublicInterface;

internal interface IMeetingRepository {
    MeetingAggregate GetMeeting(Guid id);
    void SaveMeeting(MeetingAggregate meeting);
}