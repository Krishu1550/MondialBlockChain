using System.Security.Cryptography;
using System.Text;

namespace MondialBlockChain.Core.Utils;

public static class HashHelper
{
    public static string Sha256(string input)
    {
        using var sha = SHA256.Create();

        var bytes =
            sha.ComputeHash(
                Encoding.UTF8.GetBytes(input));

        return Convert.ToHexString(bytes);
    }
}