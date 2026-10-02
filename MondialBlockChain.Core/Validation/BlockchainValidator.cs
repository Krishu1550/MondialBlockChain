using MondialBlockChain.Core.Models;
using MondialBlockChain.Core.Utils;

namespace MondialBlockChain.Core.Validation;

public static class BlockchainValidator
{
    public static bool IsValid(
        IEnumerable<Block> blocks)
    {
        var chain =
            blocks.ToList();

        for (int i = 1; i < chain.Count; i++)
        {
            var current =
                chain[i];

            var previous =
                chain[i - 1];

            if (current.PreviousHash
                != previous.Hash)
                return false;

            if (current.Hash
                != BlockHasher.Calculate(current))
                return false;
        }

        return true;
    }
}