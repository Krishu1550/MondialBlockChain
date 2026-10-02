namespace MondialBlockChain.Abstractions.Events;

public interface IEventBus
{
    void Publish(
        string eventName,
        object payload);
}