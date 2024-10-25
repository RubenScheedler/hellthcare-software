namespace Domain.Meeting;

public class PlanMeetingPolicy(
    IMeetingRepository repository
) {
    public void HandleMessage(PlanMeetingCommand command) {
        // TODO check for location availability
        repository.SaveMeeting(new MeetingAggregate(
                Guid.NewGuid(),
                command.Participants
            )
        )
    }
}