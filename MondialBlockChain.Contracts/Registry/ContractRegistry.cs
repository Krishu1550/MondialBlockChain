using MondialBlockChain.Abstractions.Contracts;

namespace MondialBlockChain.Contracts.Registry;

public class ContractRegistry : IContractRegistry
{
    private readonly Dictionary<string, IContract>
        _contracts = new();

    public string Deploy(
        IContract contract)
    {
        _contracts[contract.Address] =
            contract;

        return contract.Address;
    }

    public IContract? Get(
        string address)
    {
        _contracts.TryGetValue(
            address,
            out var contract);

        return contract;
    }
}