using MondialBlockChain.Core.Models;

namespace MondialBlockChain.Tests;

public class TransactionTests
{
    [Fact]
    public void Transaction_Should_Create_Id()
    {
        var tx = new Transaction();

        Assert.NotEqual(
            Guid.Empty,
            tx.Id);
    }

    [Fact]
    public void Transaction_Should_Set_Amount()
    {
        var tx = new Transaction
        {
            Amount = 100
        };

        Assert.Equal(
            100,
            tx.Amount);
    }
}