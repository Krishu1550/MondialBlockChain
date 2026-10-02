namespace MondialBlockChain.Events.Models;

public class ContractDeployedEvent
{
    public string ContractAddress { get; set; }
        = string.Empty;

    public string ContractName { get; set; }
        = string.Empty;
}