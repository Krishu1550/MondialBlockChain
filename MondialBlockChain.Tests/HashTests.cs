using MondialBlockChain.Core.Utils;

namespace MondialBlockChain.Tests;

public class HashTests
{
    [Fact]
    public void Same_Input_Should_Produce_Same_Hash()
    {
        var first =
            HashHelper.Sha256("hello");

        var second =
            HashHelper.Sha256("hello");

        Assert.Equal(
            first,
            second);
    }

    [Fact]
    public void Different_Input_Should_Produce_Different_Hashes()
    {
        var first =
            HashHelper.Sha256("a");

        var second =
            HashHelper.Sha256("b");

        Assert.NotEqual(
            first,
            second);
    }
}