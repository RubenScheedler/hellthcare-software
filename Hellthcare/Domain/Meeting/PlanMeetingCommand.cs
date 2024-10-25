namespace Domain.Meeting;

record PlanMeetingCommand(
    DateTimeOffset From,
    DateTimeOffset To,
    Guid LocationId, 
    List<Participant> Participants
);