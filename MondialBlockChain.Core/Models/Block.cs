namespace MondialBlockChain.Core.Models;

public class Block
{
    public int Index { get; set; }

    public string PreviousHash { get; set; }
        = string.Empty;

    public string Hash { get; set; }
        = string.Empty;

    public DateTime Timestamp { get; set; }
        = DateTime.UtcNow;

    public List<Transaction> Transactions
        { get; set; } = [];

    public long Nonce { get; set; }
}