namespace Domain.Meeting.PublicInterface;

public record PlanMeetingCommand(
    DateTime From,
    DateTime To,
    Guid LocationId, 
    List<Participant> Participants
);