namespace SharedKernel;

public interface IHandleMessages<in T> where T : IEvent
{
    void HandleMessage(T message);
}