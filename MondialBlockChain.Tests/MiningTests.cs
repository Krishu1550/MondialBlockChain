using MondialBlockChain.Core.Chain;
using MondialBlockChain.Core.Models;

namespace MondialBlockChain.Tests;

public class MiningTests
{
    [Fact]
    public void Mine_Should_Create_Valid_Hash()
    {
        var block =
            new Block();

        Miner.Mine(
            block,
            1);

        Assert.StartsWith(
            "0",
            block.Hash);
    }
}