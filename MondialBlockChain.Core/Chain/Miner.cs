using MondialBlockChain.Core.Models;
using MondialBlockChain.Core.Utils;

namespace MondialBlockChain.Core.Chain;

public static class Miner
{
    public static void Mine(
        Block block,
        int difficulty)
    {
        string target =
            new string('0', difficulty);

        while (true)
        {
            block.Hash =
                BlockHasher.Calculate(block);

            if (block.Hash.StartsWith(target))
                break;

            block.Nonce++;
        }
    }
}