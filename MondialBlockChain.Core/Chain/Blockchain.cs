using MondialBlockChain.Core.Models;
using MondialBlockChain.Core.Utils;

namespace MondialBlockChain.Core.Chain;

public class Blockchain
{
    public List<Block> Blocks { get; }
        = [];

    public Blockchain()
    {
        Blocks.Add(CreateGenesisBlock());
    }

    private Block CreateGenesisBlock()
    {
        var block = new Block
        {
            Index = 0,
            PreviousHash = "0"
        };

        block.Hash =
            BlockHasher.Calculate(block);

        return block;
    }

    public Block GetLatestBlock()
    {
        return Blocks[^1];
    }

    public void AddBlock(Block block)
    {
        block.Index = Blocks.Count;

        block.PreviousHash =
            GetLatestBlock().Hash;

        block.Hash =
            BlockHasher.Calculate(block);

        Blocks.Add(block);
    }
}