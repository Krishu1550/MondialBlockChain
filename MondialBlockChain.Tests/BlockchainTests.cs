using MondialBlockChain.Core.Chain;
using MondialBlockChain.Core.Models;
using MondialBlockChain.Core.Validation;

namespace MondialBlockChain.Tests;

public class BlockchainTests
{
    [Fact]
    public void Genesis_Block_Should_Exist()
    {
        var chain = new Blockchain();

        Assert.Single(chain.Blocks);
    }

    [Fact]
    public void Genesis_Block_Index_Should_Be_Zero()
    {
        var chain = new Blockchain();

        Assert.Equal(0, chain.Blocks[0].Index);
    }

    [Fact]
    public void AddBlock_Should_Increase_Chain_Length()
    {
        var chain = new Blockchain();

        chain.AddBlock(new Block());

        Assert.Equal(2, chain.Blocks.Count);
    }

    [Fact]
    public void New_Block_Should_Link_Previous_Hash()
    {
        var chain = new Blockchain();

        chain.AddBlock(new Block());

        var second = chain.Blocks[1];

        Assert.Equal(
            chain.Blocks[0].Hash,
            second.PreviousHash);
    }

    [Fact]
    public void Blockchain_Should_Be_Valid()
    {
        var chain = new Blockchain();

        chain.AddBlock(new Block());

        bool valid =
            BlockchainValidator.IsValid(
                chain.Blocks);

        Assert.True(valid);
    }

    [Fact]
    public void Blockchain_Should_Detect_Tampering()
    {
        var chain = new Blockchain();

        chain.AddBlock(new Block());

        chain.Blocks[1].PreviousHash =
            "tampered";

        bool valid =
            BlockchainValidator.IsValid(
                chain.Blocks);

        Assert.False(valid);
    }
}