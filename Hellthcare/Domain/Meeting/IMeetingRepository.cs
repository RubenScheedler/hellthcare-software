namespace Domain.Meeting;

internal interface IMeetingRepository {
    MeetingAggregate GetMeeting(Guid id);
    void SaveMeeting(MeetingAggregate meeting);
}