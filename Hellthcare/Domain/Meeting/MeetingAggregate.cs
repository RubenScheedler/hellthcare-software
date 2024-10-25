namespace Domain.Meeting;

public class MeetingAggregate(Guid id, DateTime from, DateTime To, List<Participant> participants) {
    private Guid Id { get; set; } = id;
    private DateTime From { get; set; } = from;
    private DateTime To { get; set; } = to;
    private List<Participant> Participants {get; } = participants;
}