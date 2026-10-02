using MondialBlockChain.Core.Models;
using MondialBlockChain.Core.Utils;

namespace MondialBlockChain.Tests;

public class MerkleTreeTests
{
    [Fact]
    public void MerkleRoot_Should_Not_Be_Empty()
    {
        var txs = new List<Transaction>
        {
            new() { Amount = 10 },
            new() { Amount = 20 }
        };

        var root =
            MerkleTree.Compute(txs);

        Assert.NotEmpty(root);
    }

    [Fact]
    public void Empty_List_Should_Return_Empty_String()
    {
        var result =
            MerkleTree.Compute([]);

        Assert.Equal(
            string.Empty,
            result);
    }
}