namespace MondialBlockChain.Events.Models;

public class ContractExecutedEvent
{
    public string ContractAddress { get; set; }
        = string.Empty;

    public string MethodName { get; set; }
        = string.Empty;

    public DateTime ExecutedAt { get; set; }
        = DateTime.UtcNow;
}