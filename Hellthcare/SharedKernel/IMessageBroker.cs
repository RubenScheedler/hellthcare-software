namespace SharedKernel;

public interface IMessageBroker {
    void Publish(IEvent @event);
}