using MondialBlockChain.Abstractions.Contracts;

namespace MondialBlockChain.Abstractions.Execution;

public interface ISmartContractEngine
{
    object? Execute(
        IContract contract,
        string method,
        params object[] args);
}