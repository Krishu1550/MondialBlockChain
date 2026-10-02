namespace MondialBlockChain.Abstractions.Contracts;

public interface IContractRegistry
{
    string Deploy(IContract contract);

    IContract? Get(string address);
}