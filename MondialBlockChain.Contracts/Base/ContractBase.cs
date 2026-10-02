using MondialBlockChain.Abstractions.Contracts;
using MondialBlockChain.Contracts.Models;

namespace MondialBlockChain.Contracts.Base;

public abstract class ContractBase : IContract
{
    public string Address { get; set; }
        = Guid.NewGuid().ToString();

    public virtual string Name =>
        GetType().Name;

    protected ContractState State { get; }
        = new();

    public abstract object? Execute(
        string method,
        params object[] args);
}
