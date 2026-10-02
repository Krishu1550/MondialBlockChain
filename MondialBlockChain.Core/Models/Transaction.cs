namespace MondialBlockChain.Core.Models;

public class Transaction
{
    public Guid Id { get; init; }
        = Guid.NewGuid();

    public string From { get; set; }
        = string.Empty;

    public string To { get; set; }
        = string.Empty;

    public decimal Amount { get; set; }

    public DateTime Timestamp { get; init; }
        = DateTime.UtcNow;
}
