using MondialBlockChain.Contracts;

namespace MondialBlockChain.Tests;

public class ContractTests
{
    [Fact]
    public void Counter_Should_Start_At_Zero()
    {
        var contract =
            new CounterContract();

        Assert.Equal(
            0,
            contract.GetCount());
    }

    [Fact]
    public void Increment_Should_Increase_Count()
    {
        var contract =
            new CounterContract();

        contract.Increment();

        Assert.Equal(
            1,
            contract.GetCount());
    }

    [Fact]
    public void Increment_Twice_Should_Return_2()
    {
        var contract =
            new CounterContract();

        contract.Increment();
        contract.Increment();

        Assert.Equal(
            2,
            contract.GetCount());
    }
}