namespace MondialBlockChain.Contracts.Models;

public class ContractState
{
    private readonly Dictionary<string, object> _storage = new();

    public void Set(string key, object value)
    {
        _storage[key] = value;
    }

    public T Get<T>(string key)
    {
        return (T)_storage[key];
    }

    public bool Exists(string key)
    {
        return _storage.ContainsKey(key);
    }
}