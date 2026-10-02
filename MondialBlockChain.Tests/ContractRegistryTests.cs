using MondialBlockChain.Contracts;
using MondialBlockChain.Contracts.Registry;

namespace MondialBlockChain.Tests;

public class ContractRegistryTests
{
    [Fact]
    public void Deploy_Should_Return_Address()
    {
        var registry =
            new ContractRegistry();

        var contract =
            new CounterContract();

        string address =
            registry.Deploy(contract);

        Assert.NotEmpty(address);
    }

    [Fact]
    public void Get_Should_Return_Contract()
    {
        var registry =
            new ContractRegistry();

        var contract =
            new CounterContract();

        var address =
            registry.Deploy(contract);

        var loaded =
            registry.Get(address);

        Assert.NotNull(loaded);
    }
}