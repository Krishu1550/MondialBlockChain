namespace MondialBlockChain.Abstractions.Contracts;

public interface IContract
{
    string Address { get; }

    string Name { get; }

    object? Execute(
        string method,
        params object[] args);
}