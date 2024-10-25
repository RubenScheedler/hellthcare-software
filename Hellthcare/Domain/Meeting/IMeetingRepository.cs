namespace Domain.Meeting;

class IMeetingRepository {
    public MeetingAggregate GetMeeting(Guid id);
    public void SaveMeeting(MeetingAggregate meeting);
}