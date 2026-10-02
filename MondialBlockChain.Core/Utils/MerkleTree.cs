using MondialBlockChain.Core.Models;

namespace MondialBlockChain.Core.Utils;

public static class MerkleTree
{
    public static string Compute(
        IEnumerable<Transaction> txs)
    {
        var hashes =
            txs.Select(t =>
                HashHelper.Sha256(
                    $"{t.Id}{t.From}{t.To}{t.Amount}"))
                .ToList();

        if (!hashes.Any())
            return string.Empty;

        while (hashes.Count > 1)
        {
            var nextLevel =
                new List<string>();

            for (int i = 0;
                 i < hashes.Count;
                 i += 2)
            {
                string left = hashes[i];

                string right =
                    i + 1 < hashes.Count
                    ? hashes[i + 1]
                    : left;

                nextLevel.Add(
                    HashHelper.Sha256(
                        left + right));
            }

            hashes = nextLevel;
        }

        return hashes[0];
    }
}