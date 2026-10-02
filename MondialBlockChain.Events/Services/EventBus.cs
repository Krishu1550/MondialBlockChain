using MondialBlockChain.Abstractions.Events;
using MondialBlockChain.Events.Models;

namespace MondialBlockChain.Events.Services;

public class EventBus : IEventBus
{
    private readonly List<BlockchainEvent>
        _events = new();

    public event Action<BlockchainEvent>? EventPublished;

    public IReadOnlyCollection<BlockchainEvent>
        Events => _events.AsReadOnly();

    public void Publish(
        string eventName,
        object payload)
    {
        var blockchainEvent =
            new BlockchainEvent
            {
                Name = eventName,
                Payload = payload
            };

        _events.Add(blockchainEvent);

        EventPublished?.Invoke(
            blockchainEvent);
    }
}