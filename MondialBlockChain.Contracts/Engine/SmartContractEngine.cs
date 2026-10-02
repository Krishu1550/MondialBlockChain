using System.Reflection;
using MondialBlockChain.Abstractions.Contracts;
using MondialBlockChain.Abstractions.Execution;

namespace MondialBlockChain.Contracts.Engine;

public class SmartContractEngine : ISmartContractEngine
{
    public object? Execute(
        IContract contract,
        string method,
        params object[] args)
    {
        var methodInfo =
            contract.GetType().GetMethod(
                method,
                BindingFlags.Public |
                BindingFlags.Instance);

        if (methodInfo == null)
        {
            throw new InvalidOperationException(
                $"Method '{method}' not found.");
        }

        return methodInfo.Invoke(
            contract,
            args);
    }
}