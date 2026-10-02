using MondialBlockChain.Contracts;
using MondialBlockChain.Contracts.Engine;

namespace MondialBlockChain.Tests;

public class SmartContractEngineTests
{
    [Fact]
    public void Execute_Should_Invoke_Method()
    {
        var contract =
            new CounterContract();

        var engine =
            new SmartContractEngine();

        engine.Execute(
            contract,
            nameof(
                CounterContract.Increment));

        Assert.Equal(
            1,
            contract.GetCount());
    }

    [Fact]
    public void Invalid_Method_Should_Throw()
    {
        var contract =
            new CounterContract();

        var engine =
            new SmartContractEngine();

        Assert.Throws<InvalidOperationException>(
            () => engine.Execute(
                contract,
                "BadMethod"));
    }
}