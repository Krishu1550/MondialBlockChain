namespace MondialBlockChain.Events.Models;

public class BlockchainEvent
{
    public Guid Id { get; init; }
        = Guid.NewGuid();

    public string Name { get; init; }
        = string.Empty;

    public object? Payload { get; init; }

    public DateTime Timestamp { get; init; }
        = DateTime.UtcNow;
}