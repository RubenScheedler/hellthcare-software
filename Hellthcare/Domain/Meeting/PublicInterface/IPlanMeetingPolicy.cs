namespace Domain.Meeting.PublicInterface;

public interface IPlanMeetingPolicy
{
    void HandleMessage(PlanMeetingCommand command);
}