using MondialBlockChain.Core.Models;

namespace MondialBlockChain.Core.Utils;

public static class BlockHasher
{
    public static string Calculate(Block block)
    {
        var raw =
            $"{block.Index}" +
            $"{block.PreviousHash}" +
            $"{block.Timestamp:O}" +
            $"{block.Nonce}" +
            $"{block.Transactions.Count}";

        return HashHelper.Sha256(raw);
    }
}