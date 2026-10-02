using MondialBlockChain.Contracts.Base;

namespace MondialBlockChain.Contracts;

public class CounterContract : ContractBase
{
    public int Increment()
    {
        int value =
            State.Exists("count")
                ? State.Get<int>("count")
                : 0;

        value++;

        State.Set("count", value);

        return value;
    }

    public int GetCount()
    {
        return State.Exists("count")
            ? State.Get<int>("count")
            : 0;
    }

    public override object? Execute(
        string method,
        params object[] args)
    {
        return method switch
        {
            nameof(Increment) => Increment(),
            nameof(GetCount) => GetCount(),
            _ => throw new NotSupportedException(
                $"Method {method} not supported")
        };
    }
}